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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalProject.Admin_Stuff
{
    public partial class Users : MainControl
    {
        public string conString = "Data Source=DESKTOP-BFUHDVD;Initial Catalog=CSDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        private string userID, userName, password, firstName, lastName, phone, email, gender, address, userType;
        public Users()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e) //Refresh button
        {
            string query = "SELECT * FROM Users";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            catch (SqlException)
            {
                MessageBox.Show("Error in the database");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occured...\n" + ex);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            userID = textBox5.Text.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userName = textBox1.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            firstName = textBox6.Text.ToString();
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            lastName = textBox7.Text.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            phone = textBox8.Text.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            email = textBox3.Text.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            gender = textBox4.Text.ToString();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            address = textBox9.Text.ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            userType = textBox10.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = @"INSERT INTO Users(UserName, Password, F_Name, L_Name, Phone, Email, Gender, Address, UserType) VALUES
                                (@userName, @password, @firstName, @lastName, @phone, @email, @gender, @address, @userType)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@userType", userType);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter the correct value");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error in the database" + ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error occured" + ex);
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            //if (con.State == System.Data.ConnectionState.Open)
            //{
            //    string query = @"UPDATE Users SET UserName = @userName, Password = @";
            //}
        }
    }
}
