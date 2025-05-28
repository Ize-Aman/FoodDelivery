using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalProject.Admin_Stuff
{
    public partial class Restaurants : MainControl
    {
        public string conString = "Data Source=DESKTOP-BFUHDVD;Initial Catalog=CSDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        private string restaurantID, name, location, phone;
        public Restaurants()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e) //refresh button
        {
            string query = "SELECT * FROM Restaurant";
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = @"INSERT INTO Restaurant(Name, Location, Phone) VALUES
                                (@name, @location, @phone)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@phone", phone);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            restaurantID = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            name = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            location = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            phone = textBox4.Text;
        }

        private void button2_Click(object sender, EventArgs e) //update
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                List<string> updates = new List<string>();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                if (!string.IsNullOrWhiteSpace(name))
                {
                    updates.Add("Name = @name");
                    cmd.Parameters.AddWithValue("@Name", name);
                }
                if (!string.IsNullOrWhiteSpace(location))
                {
                    updates.Add("Location = @location");
                    cmd.Parameters.AddWithValue("@location", location);
                }
                if (!string.IsNullOrWhiteSpace(phone))
                {
                    updates.Add("Phone = @phone");
                    cmd.Parameters.AddWithValue("@phone", phone);
                }

                if (updates.Count == 0)
                {
                    MessageBox.Show("Please enter at least one field to update.");
                    return;
                }

                // Add WHERE clause
                cmd.Parameters.AddWithValue("@restaurantID", restaurantID);

                string updateClause = string.Join(", ", updates);
                string query = $"UPDATE Restaurant SET {updateClause} WHERE RestaurantID = @restaurantID";
                cmd.CommandText = query;

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Updated successfully!" : "No restaurant found with the given ID.");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter the correct value.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error in the database: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error occurred: " + ex.Message);
                }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e) //delete button
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "DELETE FROM Restaurant WHERE RestaurantID = @restaurantID";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@restaurantID", restaurantID);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
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
            }
        }

        private void button4_Click(object sender, EventArgs e) //total restaurants button
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            int count = 0;

            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT COUNT(*) FROM Restaurant";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    count = count = (int)cmd.ExecuteScalar();
                    textBox11.Text = count.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error occured" + ex);
                }
            }
        }
    }
}
