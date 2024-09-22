using ProjectEPI.Constants;
using ProjectEPI.Data;
using ProjectEPI.Services;

namespace ProjectEPI.Controls
{
    public partial class SettingControl : UserControl
    {
        private SettingService _settingService;
        private DatabaseManager _databaseManager;

        public SettingControl()
        {
            InitializeComponent();
        }

        public void InitializeServices(SettingService settingService, DatabaseManager databaseManager)
        {
            _settingService = settingService;
            _databaseManager = databaseManager;
        }

        public void FillSettingFields()
        {
            FieldSettingsNotificationsMaturityInterval.Text = _settingService.GetMaturityIntervalDays().ToString();
        }

        private static bool ConfirmAction()
        {
            var confirmation = MessageBox.Show($"Tem certeza que deseja atualizar as configurações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            return confirmation == DialogResult.Yes;
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            if (ConfirmAction())
            {
                try
                {
                    var queryUpdate = "UPDATE public.settings SET value = @value, updated_date=@updateDate WHERE key=@key;";

                    _databaseManager.ExecuteNonQuery(queryUpdate, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@value", FieldSettingsNotificationsMaturityInterval.Text);
                        cmd.Parameters.AddWithValue("@key", SettingConstants.Keys.MATURITY_INTERVAL_DAYS);
                        cmd.Parameters.AddWithValue("@updateDate", DateTime.Now);
                    });

                    MessageBox.Show("Configurações atualizadas com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar as configurações: {ex.Message}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
