using Microsoft.Data.SqlClient;
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
        public string conString = "Data Source=DESKTOP-BFUHDVD;Initial Catalog=CSDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        public static int SelectedRestaurantID;

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
            this.MaximizeBox = false;
        }

        public CustomerLanding(Register _registerForm, Login _loginForm)
        {
            InitializeComponent();
            this._loginForm = _loginForm;
            this._registerForm = _registerForm;
            this.MaximizeBox = false;
        }

        public CustomerLanding()
        {
            InitializeComponent();
            this.MaximizeBox = false;
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
            string restaurantName = labelPizzaPalace.Text;

            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "SELECT RestaurantID FROM Restaurant WHERE Name = @name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", restaurantName);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        SelectedRestaurantID = Convert.ToInt32(result);
                        new Restaurant1().ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Restaurant not found in the database.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error:\n" + ex.Message);
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string restaurantName = labelSuchiWorld.Text;
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "SELECT RestaurantID FROM Restaurant WHERE Name = @name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", restaurantName);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        SelectedRestaurantID = Convert.ToInt32(result);
                        new Restaurant2().ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Restaurant not found in the database.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error:\n" + ex.Message);
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string restaurantName = labelBurgerTown.Text;
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "SELECT RestaurantID FROM Restaurant WHERE Name = @name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", restaurantName);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        SelectedRestaurantID = Convert.ToInt32(result);
                        new Restaurant3().ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Restaurant not found in the database.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error:\n" + ex.Message);
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string restaurantName = labelTacoHaven.Text;
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "SELECT RestaurantID FROM Restaurant WHERE Name = @name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", restaurantName);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        SelectedRestaurantID = Convert.ToInt32(result);
                        new Restaurant4().ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Restaurant not found in the database.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error:\n" + ex.Message);
                }
            }
        }
    }
}
