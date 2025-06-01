using Microsoft.Data.SqlClient;
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
    public partial class Drivers : MainControl
    {
        public string conString = "Data Source=DESKTOP-BFUHDVD;Initial Catalog=CSDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        string driverID, firstName, lastName, phone;
        double salary;
        public Drivers()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Driver";
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

        private void button1_Click(object sender, EventArgs e)//insert button
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = @"INSERT INTO Driver(F_Name, L_Name, Phone, Salary) VALUES
                                (@firstName, @lastName, @phone, @salary)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@salary", salary);

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
            driverID = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            firstName = textBox2.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            lastName = textBox5.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            phone = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                salary = double.Parse(textBox4.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the correct format please");
            }
        }

        private void button2_Click(object sender, EventArgs e)//update button
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                List<string> updates = new List<string>();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                if (!string.IsNullOrWhiteSpace(firstName))
                {
                    updates.Add("F_Name = @firstName");
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                }
                if (!string.IsNullOrWhiteSpace(lastName))
                {
                    updates.Add("L_Name = @lastName");
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                }
                if (!string.IsNullOrWhiteSpace(phone))
                {
                    updates.Add("Phone = @phone");
                    cmd.Parameters.AddWithValue("@phone", phone);
                }
                if (!string.IsNullOrWhiteSpace(salary.ToString()))
                {
                    updates.Add("Salary = @salary");
                    cmd.Parameters.AddWithValue("@salary", salary);
                }

                if (updates.Count == 0)
                {
                    MessageBox.Show("Please enter at least one field to update.");
                    return;
                }

                // Add WHERE clause
                cmd.Parameters.AddWithValue("@DriverID", driverID);

                string updateClause = string.Join(", ", updates);
                string query = $"UPDATE Driver SET {updateClause} WHERE DriverID = @driverID";
                cmd.CommandText = query;

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Updated successfully!" : "No driver found with the given ID.");
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
                string query = "DELETE FROM Driver WHERE DriverID = @driverID";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@driverID", driverID);

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

        private void button4_Click(object sender, EventArgs e) //total drivers
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            int count = 0;

            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT COUNT(*) FROM Driver";
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
