using FinalProject.Admin_Stuff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AdminLanding : Form
    {
        private Login _loginForm;
        public AdminLanding(Login loginForm) //constructor for logout button and initialize components
        {
            InitializeComponent();
            _loginForm = loginForm;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e) //the logout button
        {
            Dispose();
            _loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Users().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Orders().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Restaurants().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Drivers().ShowDialog();
        }

        
    }
}
