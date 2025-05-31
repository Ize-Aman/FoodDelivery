using Microsoft.Data.SqlClient;
namespace FinalProject
{
    public partial class Login : Form
    {
        public string conString = "Data Source=DESKTOP-BFUHDVD;Initial Catalog=CSDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        private string userName, password;
        private char userType;
        public static int LoggedInUserID;
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e) //login button
        {
            using (var con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    const string query = @"SELECT UserID, UserType FROM Users 
                                        WHERE UserName = @username AND Password = @password";

                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", userName);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // store the logged‐in user's ID
                                LoggedInUserID = reader.GetInt32(0);
                                userType = reader.GetString(1)[0];

                                if (userType == 'A' || userType == 'a')
                                {
                                    this.Hide();
                                    var adminSide = new AdminLanding(this);
                                    adminSide.FormClosed += (s, args) => this.Close();
                                    adminSide.Show();
                                }
                                else if (userType == 'C' || userType == 'c')
                                {
                                    this.Hide();
                                    var customerSide = new CustomerLanding(this);
                                    customerSide.FormClosed += (s, args) => this.Close();
                                    customerSide.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Unauthorized user type.", "Login Error",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Account not found, please register!", "Login Failed",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error:\n" + ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error:\n" + ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //quit button
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //register linked label
        {
            this.Hide();
            var registerForm = new Register(this);
            registerForm.FormClosed += (s, args) => this.Close();
            registerForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //txtUserName 
        {
            userName = textBox1.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //txtPassword
        {
            password = textBox2.Text.ToString();
        }
    }
}
