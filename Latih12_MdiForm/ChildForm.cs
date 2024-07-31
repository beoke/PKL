using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latih12_MdiForm
{
    public partial class Mahasiswa : Form
    {
        private readonly DbDal _dbdal;
        public Mahasiswa()
        {
            InitializeComponent();
            _dbdal = new DbDal();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            /*  var caridata = _dbdal.List(); // kenapa list, karena list dari DbDal yang terkonek dengan database
            dataGridView1.DataSource = caridata;*/
            try
            {
                var caridata = _dbdal.GetData();
                if (caridata != null && caridata.Any())
                {
                    dataGridView1.DataSource = caridata.ToList(); // Convert to List for DataGridView
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
