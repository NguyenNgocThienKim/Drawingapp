using System.Data;
using Drawingapp.Resources;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace Drawingapp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

#pragma warning disable 108
        private void Closer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
#pragma warning disable 108

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MOVETOFORM2_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void MOVETOFORM2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// Step 1: Get user input
            string username = textusername.Text.Trim();
            string password = textpassword.Text.Trim();

            // Step 2: Check for empty fields before database connection
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method to prevent further execution
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method to prevent further execution
            }

            // Step 3: Database connection
            DB db = new DB();
            MySqlConnection connection = db.getConnection();

            try
            {
                // Step 4: Open connection
                connection.Open();

                // Step 5: Define the SQL query
                string query = "SELECT * FROM `users` WHERE `username` = @usn AND `password` = @pass";

                // Step 6: Prepare the command and bind parameters
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@usn", username);
                command.Parameters.AddWithValue("@pass", password);

                // Step 7: Execute the query
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Step 8: Check if user exists
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Form3 ba = new Form3();
                    ba.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Step 9: Close connection
                connection.Close();
            }
        }
    }
}
