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
    public partial class Matakuliah : Form
    {
        private readonly DbDal dbDal;
        public Matakuliah()
        {
            InitializeComponent();
            dbDal = new DbDal();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            try
            {
                var data = dbDal.GetData();
                var matakuliahlist = data.MatakuliahList.ToList();

                if (matakuliahlist.Any())
                {
                    dataGridView1.DataSource = matakuliahlist;
                }
                else
                {
                    MessageBox.Show("not data found");

                }
            }
            catch(Exception x)
            {
                MessageBox.Show($"An error occurred: {x.Message}");
            }
            
        }           
        }
}
