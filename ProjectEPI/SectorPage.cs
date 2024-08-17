using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEPI
{
    public partial class SectorPage : Form
    {
        public SectorPage()
        {
            InitializeComponent();

            ShowSectorsGrid();
        }

        public void ShowSectorsGrid()
        {
            SectorData sd = new();
            List<SectorData> sectors = sd.GetSectors();

            dataGridViewSectors.DataSource = sectors;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
