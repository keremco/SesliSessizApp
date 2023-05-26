using SesliSessizApp.Services;

namespace SesliSessizApp
{
    public partial class Form1 : Form
    {
        StringIslemleriService _servis = new StringIslemleriService();
        public Form1()
        {
            InitializeComponent();
        }

        private void bBul_Click(object sender, EventArgs e)
        {
            rtbSonuc.Text = _servis.SesliSessizHarfBul(tbKelime.Text.Trim(), rbSesli.Checked);
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tbKelime.Text = "";
            rtbSonuc.Text = "";
            rbSesli.Checked = true;
        }
    }
}