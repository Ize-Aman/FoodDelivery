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

namespace FinalProject.Admin_Stuff
{
    public partial class Orders : MainControl
    {
        public string conString = "Data Source=DESKTOP-BFUHDVD;Initial Catalog=CSDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        string orderID, customerID, restaurantID;
        double totalCost;
        public Orders()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [Order]";
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

        private void button1_Click(object sender, EventArgs e) //insert buton
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = @"INSERT INTO [Order](CustomerID, RestaurantId, TotalCost) VALUES
                                (@customerID, @restaurantID, @totalCost)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@customerID", customerID);
                cmd.Parameters.AddWithValue("@restaurantID", restaurantID);
                cmd.Parameters.AddWithValue("@TotalCost", totalCost);

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
            orderID = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            customerID = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            restaurantID = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            totalCost = double.Parse(textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e) //update button
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                List<string> updates = new List<string>();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                if (!string.IsNullOrWhiteSpace(customerID))
                {
                    updates.Add("CustomerID = @customerID");
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                }
                if (!string.IsNullOrWhiteSpace(restaurantID))
                {
                    updates.Add("RestaurantID = @restaurantID");
                    cmd.Parameters.AddWithValue("@restaurantID", restaurantID);
                }
                if (!string.IsNullOrWhiteSpace(totalCost.ToString()))
                {
                    updates.Add("TotalCost = @totalCost");
                    cmd.Parameters.AddWithValue("@totalCost", totalCost);
                }

                if (updates.Count == 0)
                {
                    MessageBox.Show("Please enter at least one field to update.");
                    return;
                }

                // Add WHERE clause
                cmd.Parameters.AddWithValue("@OrderID", orderID);

                string updateClause = string.Join(", ", updates);
                string query = $"UPDATE [Order] SET {updateClause} WHERE OrderID = @orderID";
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

        private void button3_Click(object sender, EventArgs e)//delete button
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "DELETE FROM [Order] WHERE OrderID = @orderID";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@orderID", orderID);

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

        private void button4_Click(object sender, EventArgs e)//total orders
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            int count = 0;

            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT COUNT(*) FROM [Order]";
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
