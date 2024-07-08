using System.ComponentModel.Design.Serialization;

namespace Latih8_WinformEvent
{
    public partial class Form1 : Form
    {
        private List<SiswaModel> _listSiswa;
        private BindingSource _bindingSoure;
        public Form1()
        {
            InitializeComponent();
            GenerateData();
            
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void GenerateData()
        {
            _listSiswa = new List<SiswaModel>
            {
                new SiswaModel("12001", "Agus Binawan", new DateTime(2010,3,1), "Laki-Laki", "Puri Indah Santoso C4, Bantul", "RPL"),
                new SiswaModel("12002", "Budi Cahyadi", new DateTime(2010,5,11), "Laki-Laki", "Mranggen CT4/211, Jogjakarta", "RPL"),
                new SiswaModel("12003", "Candra Darmawan", new DateTime(2010,9,13), "Laki-Laki", "Jl.Sukun Raya 241, Sleman", "TKJ"),
                new SiswaModel("12004", "Desya Saputri", new DateTime(2010,1,9), "Perempuan", "Perum Kelapa Gadin E/3, Jogjakarta", "MP"),
                new SiswaModel("12005", "Etik Sukmasari", new DateTime(2010,7,21), "Perempuan", "Prawirotaman MG-V/221, Jogjakarta", "AKL"),
                new SiswaModel("12006", "Firman Sihombing", new DateTime(2010,3,9), "Laki-Laki", "Kraton CT4/212, Jogjakarta", "DKV"),
                new SiswaModel("12007", "Ghina Putri", new DateTime(2010,12,4), "Perempuan", "Jl.Kaliurang Km 3, Sleman", "RPL"),
                new SiswaModel("12008", "Heri Susanto", new DateTime(2010,6,18), "Laki-Laki", "Jl.Kusbini 141, Jogjakarta", "TKJ"),
                new SiswaModel("12009", "Ivan Prasetyo", new DateTime(2010,7,23), "Laki-Laki", "Pelem Legi-1, Parangtritis", "MP"),
                new SiswaModel("12010", "Jessica Puspita", new DateTime(2010,1,31), "Perempuan", "Suryatmajan GT-V/311, Jogjakarta", "AKL"),
            };

            _bindingSoure = new BindingSource();
            _bindingSoure.DataSource = _listSiswa;

            comboBox1.Items.Add("laki laki");
            comboBox1.Items.Add("Perempuan");

            comboBox2.Items.Add("TKJ");
            comboBox2.Items.Add("RPL");
            comboBox2.Items.Add("MP");
            comboBox2.Items.Add("AKL");
            comboBox2.Items.Add("DKV");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _bindingSoure;
            dataGridView1.Columns["NIS"].Width = 50;
            dataGridView1.Columns["Nama"].Width = 150;
            dataGridView1.Columns["TglLahir"].Width = 100;
            dataGridView1.Columns["Gender"].Width = 100;
            dataGridView1.Columns["Alamat"].Width = 260;
            dataGridView1.Columns["Jurusan"].Width = 100;
            dataGridView1.Columns["TglLahir"].DefaultCellStyle.Format = "dd-MM-yyyy";
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           var nis = dataGridView1.CurrentRow.Cells["NIS"].Value.ToString();    
            var siswa = _listSiswa.FirstOrDefault(x => x.NIS == nis);


            textBox1.Text = siswa.NIS;
            textBox2.Text = siswa.Nama;
            dateTimePicker1.Value = siswa.TglLahir;
            comboBox1.Text = siswa.Gender;
            textBox3.Text = siswa.Alamat;
            comboBox2.Text = siswa.Jurusan;
        }
        private void textBox2_Validated(object sender, EventArgs e)
        {
            _listSiswa.FirstOrDefault(x => x.NIS == textBox1.Text).Nama = textBox2.Text;
            dataGridView1.Refresh();
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            _listSiswa.FirstOrDefault(x => x.NIS == textBox1.Text).Alamat = textBox3.Text;
            dataGridView1.Refresh();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _listSiswa.FirstOrDefault(x => x.NIS == textBox1.Text).TglLahir = dateTimePicker1.Value;
            dataGridView1.Refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _listSiswa.FirstOrDefault(x => x.NIS == textBox1.Text).Jurusan = comboBox2.Text;
            dataGridView1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _listSiswa.FirstOrDefault(x => x.NIS == textBox1.Text).Gender = comboBox1.Text;
            dataGridView1.Refresh();
        }


    }
}
