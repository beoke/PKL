namespace Latih12_MdiForm
{
    public partial class Form1 : Form
    {
        private Form currentChildForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var formchild = new Mahasiswa();
            formchild.MdiParent = this;
            formchild.Show();*/

            FormAnak(new Mahasiswa());
        }

        private void listMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* var form2 = new Matakuliah();
             form2.MdiParent = this;
             form2.Show();*/

            FormAnak(new Matakuliah());
        }

        private void FormAnak(Form childform)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }

            currentChildForm = childform;
            currentChildForm.MdiParent = this;
            childform.Show();
        }
    }
}
