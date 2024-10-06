using Microsoft.IdentityModel.Tokens;
using ProjectEPI.Constants;
using ProjectEPI.Data;
using ProjectEPI.Data.Dtos;
using ProjectEPI.Services;

namespace ProjectEPI.Forms
{
    public partial class SectorModal : Form
    {
        private readonly DatabaseManager _databaseService;
        private readonly SectorService _sectorService;
        private readonly SectorDto _sector;
        private readonly Action _refreshSectorGrid;
        private readonly string _modalType;

        public SectorModal(
            SectorDto sector,
            DatabaseManager dataBaseService,
            SectorService sectorService,
            Action refreshSectorGrid,
            string modalType)
        {
            InitializeComponent();

            _sector = sector;
            _databaseService = dataBaseService;
            _sectorService = sectorService;
            _refreshSectorGrid = refreshSectorGrid;
            _modalType = modalType;

            if (_modalType == ModalConstants.Type.EDIT)
            {
                FieldSectorId.Text = _sector.Id.ToString();
                FieldSectorName.Text = _sector.Name;

                ButtonAdd.Visible = false;
            }

            if (_modalType == ModalConstants.Type.ADD)
            {
                ButtonUpdate.Visible = false;
                ButtonDelete.Visible = false;
            }
        }

        private void ClearFields()
        {
            FieldSectorId.Text = "";
            FieldSectorName.Text = "";
        }

        private bool ValidadeFilledFields(bool checkId = false)
        {
            if (checkId && string.IsNullOrEmpty(FieldSectorId.Text))
            {
                MessageBox.Show("Por favor, selecione um setor antes de prosseguir.");
                return false;
            }

            if (FieldSectorName.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Por favor, preencha o campo antes de salvar.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private static bool ConfirmAction(string action, string id)
        {
            var confirmation = MessageBox.Show($"Tem certeza que deseja {action} o Id {id}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            return confirmation == DialogResult.Yes;
        }

        private void PictureBoxCloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            if (ValidadeFilledFields())
            {
                try
                {
                    var queryInsert = "INSERT INTO public.sectors (id, \"name\", created_date, updated_date) " +
                                      "VALUES(nextval('sectors_id_seq'::regclass), @name, @createdDate, NULL);";

                    _databaseService.ExecuteNonQuery(queryInsert, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@name", FieldSectorName.Text.Trim());
                        cmd.Parameters.AddWithValue("@createdDate", DateTime.Now);
                    });

                    _refreshSectorGrid();
                    ClearFields();
                    MessageBox.Show("Setor adicionado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar o setor: {ex.Message}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            if (ValidadeFilledFields(checkId: true) && ConfirmAction("atualizar", FieldSectorId.Text))
            {
                try
                {
                    var queryUpdate = "UPDATE public.sectors SET \"name\"=@name, updated_date=@updateDate WHERE id=@id;";

                    _databaseService.ExecuteNonQuery(queryUpdate, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@name", FieldSectorName.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", long.Parse(FieldSectorId.Text));
                        cmd.Parameters.AddWithValue("@updateDate", DateTime.Now);
                    });

                    _refreshSectorGrid();
                    ClearFields();
                    MessageBox.Show("Setor atualizado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o setor: {ex.Message}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            if (ValidadeFilledFields(checkId: true) && ConfirmAction("deletar", FieldSectorId.Text))
            {
                try
                {
                    var queryDelete = "DELETE FROM public.sectors WHERE id=@id;";

                    _databaseService.ExecuteNonQuery(queryDelete, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@id", long.Parse(FieldSectorId.Text));
                    });

                    _refreshSectorGrid();
                    ClearFields();
                    MessageBox.Show("Setor deletado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao deletar o setor: {ex.Message}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
