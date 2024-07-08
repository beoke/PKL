namespace Latih10_KoneksiDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListData();
        }

        private void ListData()
        {
            using var db = new SekolahkuDbContext();
            var listSiswa = db.Siswa.ToList();
            dataGridView1.DataSource = listSiswa;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            NewSiswa();
        }
        public void NewSiswa()
        {
            var newSiswa = new SiswaModel();
            using var db = new SekolahkuDbContext();
            db.Siswa.Add(newSiswa);
            db.SaveChanges();

            ShowInput(newSiswa);
        }
        public void ShowInput(SiswaModel siswa)
        {
            txt_siswaID.Text = siswa.SiswaId.ToString();
            txt_name.Text = siswa.SiswaName;
            txt_NIS.Text = siswa.Nis;
            txt_tempatlahir.Text = siswa.TempatLahir;
            dtp_tgl.Value = siswa.TglLahir;
            txt_alamat.Text = siswa.Alamat;
            txt_kota.Text = siswa.Kota;
            tabControl1.SelectedIndex = 1;
        }
        public void SaveData()
        {
            using var db = new SekolahkuDbContext();
            var siswa = db.Siswa.Find(int.Parse(txt_siswaID.Text));

            siswa.SiswaName = txt_name.Text;
            siswa.Nis = txt_NIS.Text;
            siswa.TempatLahir = txt_tempatlahir.Text;
            siswa.TglLahir = dtp_tgl.Value;
            siswa.Alamat = txt_alamat.Text;
            siswa.Kota = txt_kota.Text;

            db.SaveChanges();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveData();
            ListData();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var siswaId = dataGridView1.CurrentRow.Cells["SiswaId"].Value.ToString();
            if (siswaId is null)
                return;

            using var db = new SekolahkuDbContext();
            var siswa = db.Siswa.Find(int.Parse(siswaId));
            ShowInput(siswa);
        }
    }
}
