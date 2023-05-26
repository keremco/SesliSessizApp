using SesliSessizApp.Services;

namespace SesliSessizApp
{
    public partial class Form2 : Form
    {

        StringIslemleriService _servis = new StringIslemleriService();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bGuncelle_Click(object sender, EventArgs e)
        {
            rtbSonuc.Text = _servis.IlkHarfleriBuyult(tbCumle.Text);
        }
    }
}
