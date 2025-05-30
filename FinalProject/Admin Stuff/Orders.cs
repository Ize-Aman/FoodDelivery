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
        public string conString = "Data Source=DESKTOP-FNTB2VP;Initial Catalog=CSDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

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
    }
}
