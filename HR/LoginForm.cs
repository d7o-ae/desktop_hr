using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace HR
{
    public partial class LoginForm : Form
    {
        private DatabaseConnector dbConnector;

        public LoginForm()
        {
            InitializeComponent();
            dbConnector = new DatabaseConnector();
        }

        
        private bool ValidateCredentials(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

            try
            {
                dbConnector.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, dbConnector.Connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0; // If count is greater than 0, the credentials are valid
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log, show error message, etc.)
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Retrieve text from username and password TextBox controls
            string username = txtUsername.Text;
            string password = txtPassword.Text;

        

            bool valid = ValidateCredentials(username, password);
            Console.WriteLine("the response is " + valid);



               // Validate credentials
            if (ValidateCredentials(username, password))
            {
                // Open the main menu form
               MainScreenForm mainScreenForm = new MainScreenForm();
                mainScreenForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("خطأ في اسم المستخدم أو كلمة المرور , يرجى إعادة المحاولة مرة أخرى.");
            }
        }

      
    }
}