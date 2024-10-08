﻿using ProjectEPI.Data;
using ProjectEPI.Data.Dtos;
using ProjectEPI.Services;

namespace ProjectEPI.Forms
{
    public partial class MonitorEditModal : Form
    {
        private readonly EquipmentDto _equipment;
        private readonly DatabaseManager _databaseService;
        private readonly NotificationService _notificationService;
        private readonly SettingService _settingService;
        private readonly Action _refreshMonitorGrid;

        public MonitorEditModal(
            EquipmentDto equipment,
            DatabaseManager databaseService,
            Action refreshMonitorGrid,
            NotificationService notificationService,
            SettingService settingService)
        {
            InitializeComponent();

            _equipment = equipment;
            _databaseService = databaseService;
            _refreshMonitorGrid = refreshMonitorGrid;
            _notificationService = notificationService;
            _settingService = settingService;

            FieldMonitorEditModalId.Text = _equipment.Id.ToString();
            FieldMonitorEditModalName.Text = _equipment.Name;
            FieldMonitorEditModalDescription.Text = _equipment.Description;
            FieldMonitorEditModalHandlingStatus.Text = _equipment?.HandlingStatus;
            FieldMonitorEditModalIsActive.Checked = _equipment.IsActive;
            FieldMonitorEditModalMaturityDate.Value = _equipment.MaturityDate.Value;
        }

        private void MonitorEditModal_Load(object sender, EventArgs e)
        {

        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show($"Tem certeza que deseja atualizar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    var queryUpdate = "UPDATE public.equipments SET isactive = @isactive, handling_status = @handlingstatus, maturity_date = @maturitydate, updated_date=@updateDate WHERE id=@id;";

                    if (FieldMonitorEditModalHandlingStatus.Text == Constants.EquipmentConstants.HandlingStatus.FINISHED)
                    {
                        queryUpdate = $"UPDATE public.equipments SET isactive = @isactive, status = '{Constants.EquipmentConstants.EquipmentStatus.VALID}', handling_status = @handlingstatus, maturity_date = @maturitydate, updated_date=@updateDate WHERE id=@id;";

                        DeleteCurrentNotification();
                    }

                    if (FieldMonitorEditModalHandlingStatus.Text != Constants.EquipmentConstants.HandlingStatus.FINISHED)
                    {
                        var daysLimit = _settingService.GetMaturityIntervalDays();
                        var remainingDays = (FieldMonitorEditModalMaturityDate.Value.Date - DateTime.Today).Days;

                        if (remainingDays >= daysLimit)
                        {
                            queryUpdate = $"UPDATE public.equipments SET isactive = @isactive, status = '{Constants.EquipmentConstants.EquipmentStatus.VALID}', handling_status = @handlingstatus, maturity_date = @maturitydate, updated_date=@updateDate WHERE id=@id;";
                            DeleteCurrentNotification();
                        }
                    }

                    _databaseService.ExecuteNonQuery(queryUpdate, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@id", long.Parse(FieldMonitorEditModalId.Text));
                        cmd.Parameters.AddWithValue("@handlingstatus", FieldMonitorEditModalHandlingStatus.Text);
                        cmd.Parameters.AddWithValue("@isactive", FieldMonitorEditModalIsActive.Checked);
                        cmd.Parameters.AddWithValue("@maturitydate", FieldMonitorEditModalMaturityDate.Value);
                        cmd.Parameters.AddWithValue("@updateDate", DateTime.Now);
                    });

                    _notificationService.GenerateNotifications();

                    _refreshMonitorGrid();

                    MessageBox.Show("Equipamento atualizado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o setor: {ex.Message}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteCurrentNotification()
        {
            var currentNotifications = _notificationService.GetExistingNotificationsIds();

            var equipmentId = long.Parse(FieldMonitorEditModalId.Text);

            if (currentNotifications.Contains(equipmentId))
            {
                var queryDelete = "DELETE from public.notifications WHERE equipmentid = @equipmentid";

                _databaseService.ExecuteNonQuery(queryDelete, cmd =>
                {
                    cmd.Parameters.AddWithValue("@equipmentId", equipmentId);
                });
            }
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show($"Tem certeza que deseja cancelar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (confirmation == DialogResult.Yes)
            {
                Close();
            }
        }

        private void PictureBoxCloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
