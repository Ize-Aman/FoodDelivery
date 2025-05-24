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
        public AdminLanding(Login loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Dispose();
            _loginForm.Show();
        }
    }
}
