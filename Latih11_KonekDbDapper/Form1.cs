using System.Drawing.Text;

namespace Latih11_KonekDbDapper
{
    public partial class Form1 : Form
    {
        private readonly NIlaiDal _nilaiDal;
        public Form1()
        {
            InitializeComponent();
            _nilaiDal = new NIlaiDal();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var datasource = _nilaiDal.Listdata();
            dataGridView1.DataSource = datasource;
        }
    }
}
