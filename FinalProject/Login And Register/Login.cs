using Microsoft.Data.SqlClient;
namespace FinalProject
{
    public partial class Login : Form
    {
        public string conString = "Data Source=DESKTOP-BFUHDVD;Initial Catalog=CSDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        private string userName, password;
        private char userType;
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e) //login button
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT UserType FROM Users WHERE UserName = @username AND Password = @password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", userName);
                cmd.Parameters.AddWithValue ("@Password" , password);

                try
                {
                    var result = cmd.ExecuteScalar();

                    if(result != null)
                    {
                        userType = char.Parse(result.ToString());

                        if(userType == 'A' || userType == 'a')
                        {
                            this.Hide();
                            var AdminSide = new AdminLanding(this);
                            AdminSide.FormClosed += (s, args) => this.Close();
                            AdminSide.Show();
                        }

                        else if(userType == 'C' || userType == 'c')
                        {
                            this.Hide();
                            var customerSide = new CustomerLanding(this);
                            customerSide.FormClosed += (s, args) => this.Close();
                            customerSide.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account not found, please register!");
                    }
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error in the database\n" + ex);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unexpected Error occured\n" + ex);
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
