namespace Latih6_ControlWinFormCmboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Cara Manual
            comboBox1.Items.Add("Honda Brio");
            comboBox1.Items.Add("Toyota Inova");
            comboBox1.Items.Add("Isuzu Traga");

            //Cara Data Billding
            var mobil = new List<string>();
            mobil.Add("Honda Brio");
            mobil.Add("Toyota Inova");
            mobil.Add("Isuzu Traga");
            comboBox2.DataSource = mobil;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        } 
    }
}
