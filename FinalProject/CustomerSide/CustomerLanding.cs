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
    public partial class CustomerLanding : Form
    {
        private Login _loginForm;
        private Register _registerForm;

        //the following constructors are used so that the logout button works perfectly and to initialize components

        //START CONSTRUCTORS
        public CustomerLanding(Login _loginForm)
        {
            InitializeComponent();
            this._loginForm = _loginForm;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        public CustomerLanding(Register registerForm)
        {
            InitializeComponent();
            _registerForm = registerForm;
        }

        public CustomerLanding(Register _registerForm, Login _loginForm)
        {
            InitializeComponent();
            this._loginForm = _loginForm;
            this._registerForm = _registerForm;
        }

        //CONSTRUCTORS END HERE

        private void pictureBox10_Click(object sender, EventArgs e) //logout button
        {
            Dispose();
            try
            {
                _loginForm.Show();
            }
            catch (Exception)
            {
                new Login().Show();
            }
        }

        //each restaurants as a card
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new Restaurant1().ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            new Restaurant2().ShowDialog();
        }
    }
}
