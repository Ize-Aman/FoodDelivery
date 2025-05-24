namespace FinalProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AdminSide = new AdminLanding(this);
            AdminSide.FormClosed += (s, args) => this.Close();
            AdminSide.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var registerForm = new Register(this);
            registerForm.FormClosed += (s, args) => this.Close();
            registerForm.Show();
        }
    }
}
