using ShoppingApp.Forms;

namespace WinFormsApp1
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdministration_Click(object sender, EventArgs e)
        {
            AdminScreen form = new AdminScreen();
            form.Show();
            this.Hide();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            Sale form = new Sale();
            form.Show();
            this.Hide();

        }

        private void StartScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}