using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FinalProject
{
    public partial class Register : Form
    {
        private Login _loginForm;
        private string username, password, firstname, lastname, address, email, phone;
        public string conString = "Data Source=DESKTOP-BFUHDVD;Initial Catalog=CSDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        
        public Register(Login loginForm) //constructor for logout button and initialize components
        {
            InitializeComponent();
            _loginForm = loginForm;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e) //Register button
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "INSERT INTO Users(UserName, Password, F_Name, L_Name, Phone, Email, Address, UserType, Gender) VALUES (@username, @password, @firstname, @lastname, @phone, @email, @address, 'C', 'M')";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@phone", phone.ToString());
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@address", address);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully");

                    this.Hide();
                    var customerSide = new CustomerLanding(this, _loginForm);
                    customerSide.FormClosed += (s, args) => this.Close();
                    customerSide.Show();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter the correct value\n");
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("incorrect value entered or there was an Error in the database\n" + ex);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unexpected error occured\n" + ex);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //Back button
        {
            Dispose();
            _loginForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            firstname = textBox3.Text.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            lastname = textBox4.Text.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            phone = textBox5.Text.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            address = textBox6.Text.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            email = textBox7.Text.ToString();
        }
    }
}
