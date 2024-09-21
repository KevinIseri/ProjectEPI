using ProjectEPI.Data.Dtos;

namespace ProjectEPI.Forms
{
    public partial class MonitorEditModal : Form
    {
        private readonly EquipmentDto _equipment;

        public MonitorEditModal(EquipmentDto equipment)
        {
            InitializeComponent();

            _equipment = equipment;

            FieldMonitorEditModalId.Text = _equipment.Id.ToString();
        }

        private void MonitorEditModal_Load(object sender, EventArgs e)
        {

        }
    }
}
