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
    public partial class Restaurant2 : Restaurant1
    {
        public string conString = "Data Source=DESKTOP-BFUHDVD;Initial Catalog=CSDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        public Restaurant2()
        {
            InitializeComponent();



        }
        private void Restaurant2_Load(object sender, EventArgs e)
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

        private void textBoxCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            try
            {
                
                double pricePizza = 6.0;
                double priceLasagna = 5.0;
                double priceBurger = 4.0;
                double priceFanta = 2.0;

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



            // Clear receipt
            richTextBoxRecepit.Clear();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
              
                int customerId = Login.LoggedInUserID;
                int restaurantId = CustomerLanding.SelectedRestaurantID;
                decimal totalCost = decimal.Parse(textBoxTotal.Text, System.Globalization.NumberStyles.Currency);

                using (SqlConnection con = new SqlConnection(conString))
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
                            MessageBox.Show("Order confirmed.");
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

        private void pictureBoxPizza_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLazagna_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPizza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxLasagna_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
