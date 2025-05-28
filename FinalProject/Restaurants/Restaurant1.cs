using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data;
using Microsoft.Data.SqlClient;

namespace FinalProject
{
    public partial class Restaurant1 : Form
    {
        public Restaurant1()
        {
            InitializeComponent();
        }

        private void Restaurant1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                comboBoxLasagna.Items.Add(i);
                comboBoxPizza.Items.Add(i);
                comboBoxBurger.Items.Add(i);
                comboBoxFanta.Items.Add(i);

            }
            comboBoxLasagna.SelectedIndex = 0;
            comboBoxPizza.SelectedIndex = 0;
            comboBoxBurger.SelectedIndex = 0;
            comboBoxFanta.SelectedIndex = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLazagna_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse values from TextBoxes
                int customerId = int.Parse(textBoxCustomerID.Text);
                int restaurantId = int.Parse(textBoxRestaurantID.Text);
                decimal totalCost = decimal.Parse(textBoxTotal.Text, System.Globalization.NumberStyles.Currency);

                // Your connection string (adjust Data Source and Initial Catalog if needed)
                string connectionString = "Data Source=DESKTOP-FNTB2VP;Initial Catalog=CSDB;Integrated Security=True;Trust Server Certificate=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "INSERT INTO [Order] (CustomerID, RestaurantID, TotalCost) VALUES (@CustomerID, @RestaurantID, @TotalCost)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        cmd.Parameters.AddWithValue("@RestaurantID", restaurantId);
                        cmd.Parameters.AddWithValue("@TotalCost", totalCost);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("Order confirmed and saved to database.");
                        else
                            MessageBox.Show("No data inserted.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error confirming order: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Updated Prices
                double pricePizza = 3.0;
                double priceLasagna = 6.0;
                double priceBurger = 5.0;   // Updated
                double priceFanta = 1.0;    // Updated

                // Quantities from ComboBoxes if checkbox is checked
                int qtyPizza = checkBoxPizza.Checked && comboBoxPizza.SelectedItem != null
                    ? Convert.ToInt32(comboBoxPizza.SelectedItem) : 0;
                int qtyLasagna = checkBoxLazagna.Checked && comboBoxLasagna.SelectedItem != null
                    ? Convert.ToInt32(comboBoxLasagna.SelectedItem) : 0;
                int qtyBurger = checkBoxBurger.Checked && comboBoxBurger.SelectedItem != null
                    ? Convert.ToInt32(comboBoxBurger.SelectedItem) : 0;
                int qtyFanta = checkBoxFanta.Checked && comboBoxFanta.SelectedItem != null
                    ? Convert.ToInt32(comboBoxFanta.SelectedItem) : 0;

                // Subtotal calculation
                double subTotal = (qtyPizza * pricePizza)
                                + (qtyLasagna * priceLasagna)
                                + (qtyBurger * priceBurger)
                                + (qtyFanta * priceFanta);

                // Tax = 10%
                double tax = subTotal * 0.10;

                // Final Total
                double total = subTotal + tax;

                // Show results in TextBoxes
                textBoxSubTotal.Text = subTotal.ToString("C");
                textBoxTax.Text = tax.ToString("C");
                textBoxTotal.Text = total.ToString("C");

                // Show Receipt in RichTextBox
                richTextBoxRecepit.Clear();
                if (qtyPizza > 0)
                    richTextBoxRecepit.AppendText($"Pizza x{qtyPizza} = {(qtyPizza * pricePizza):C}\n");
                if (qtyLasagna > 0)
                    richTextBoxRecepit.AppendText($"Lasagna x{qtyLasagna} = {(qtyLasagna * priceLasagna):C}\n");
                if (qtyBurger > 0)
                    richTextBoxRecepit.AppendText($"Burger x{qtyBurger} = {(qtyBurger * priceBurger):C}\n");
                if (qtyFanta > 0)
                    richTextBoxRecepit.AppendText($"Fanta x{qtyFanta} = {(qtyFanta * priceFanta):C}\n");

                richTextBoxRecepit.AppendText($"\nSub Total: {subTotal:C}\nTax: {tax:C}\nTotal: {total:C}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }

        }


        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void comboBoxLasagna_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxPizza_Click(object sender, EventArgs e)
        {

        }

        private void labelPriceLazagna_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Uncheck all checkboxes
            checkBoxPizza.Checked = false;
            checkBoxLazagna.Checked = false;
            checkBoxBurger.Checked = false;
            checkBoxFanta.Checked = false;

            // Reset ComboBoxes 
            comboBoxPizza.SelectedIndex = 0;
            comboBoxLasagna.SelectedIndex = 0;
            comboBoxBurger.SelectedIndex = 0;
            comboBoxFanta.SelectedIndex = 0;

            // Clear TextBoxes
            textBoxSubTotal.Clear();
            textBoxTax.Clear();
            textBoxTotal.Clear();
            textBoxCustomerID.Clear();
            

            // Clear receipt
            richTextBoxRecepit.Clear();
        }

        private void labelSubTotal_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
    }
}
