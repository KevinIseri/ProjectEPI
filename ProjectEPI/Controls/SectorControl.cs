using ProjectEPI.Constants;
using ProjectEPI.Data;
using ProjectEPI.Data.Dtos;
using ProjectEPI.Forms;
using ProjectEPI.Services;

namespace ProjectEPI.Controls
{
    public partial class SectorControl : UserControl
    {
        private DatabaseManager _databaseService;
        private SectorService _sectorService;

        public SectorControl()
        {
            InitializeComponent();
        }

        public void InitializeServices(DatabaseManager databaseService, SectorService sectorService)
        {
            _databaseService = databaseService;
            _sectorService = sectorService;

            ShowSectorsGrid();
        }

        public void ShowSectorsGrid()
        {
            var sectors = _sectorService.GetSectors();

            SectorDataGridView.DataSource = sectors;

            SectorDataGridView.Columns["Edit"].DisplayIndex = SectorDataGridView.Columns.Count - 1;
            SectorDataGridView.Columns["Name"].HeaderText = "Nome";
        }

        private void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && SectorDataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                DataGridViewRow row = SectorDataGridView.Rows[e.RowIndex];

                SectorModal sectorModal = new(
                    new SectorDto
                    {
                        Id = (long)row.Cells["Id"].Value,
                        Name = row.Cells["Name"].Value.ToString()
                    },
                    _databaseService,
                    _sectorService,
                    ShowSectorsGrid,
                    ModalConstants.Type.EDIT
                );

                sectorModal.ShowDialog();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxAddClick(object sender, EventArgs e)
        {
            SectorModal sectorModal = new(
                new SectorDto(),
                _databaseService,
                _sectorService,
                ShowSectorsGrid,
                ModalConstants.Type.ADD
            );

            sectorModal.ShowDialog();
        }
    }
}
