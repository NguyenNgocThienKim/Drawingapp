using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Drawingapp.Resources
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();  
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void MOVETOFORM2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void Minimize1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close1_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            // Check if any fields are empty
            if (string.IsNullOrWhiteSpace(textBoxfirstname.Text) || textBoxfirstname.Text.Equals("Firstname", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please enter your Firstname!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxlastname.Text) || textBoxlastname.Text.Equals("Lastname", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please enter your Lastname!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxemailaddress.Text) || textBoxemailaddress.Text.Equals("Email Address", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please enter your Email Address!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxusername.Text) || textBoxusername.Text.Equals("Username", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please enter a Username!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxpassword.Text) || textBoxpassword.Text.Equals("Password", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please enter a Password!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxconfirmpassword.Text) || textBoxconfirmpassword.Text.Equals("Confirm Password", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please confirm your Password!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if passwords match
            if (!textBoxpassword.Text.Equals(textBoxconfirmpassword.Text))
            {
                MessageBox.Show("Passwords do not match!", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if username already exists
            if (checkUsername())
            {
                MessageBox.Show($"The username '{textBoxusername.Text}' already exists. Please choose a different one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert user into database
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `users`(`Firstname`, `Lastname`, `Emailaddress`, `username`, `password`) VALUES (@fn, @ls, @email, @usnn, @pass)", db.getConnection());

            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxfirstname.Text.Trim();
            cmd.Parameters.Add("@ls", MySqlDbType.VarChar).Value = textBoxlastname.Text.Trim();
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxemailaddress.Text.Trim();
            cmd.Parameters.Add("@usnn", MySqlDbType.VarChar).Value = textBoxusername.Text.Trim();
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxpassword.Text.Trim();

            try
            {
                db.openConnection();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Your Account Has Been Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                // Check if the exception is due to duplicate username
                if (ex.Number == 1062) // Error code for duplicate entry
                {
                    MessageBox.Show($"The username '{textBoxusername.Text}' is already taken. Please choose another.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                db.closeConnection();
            }
        }




        public Boolean checkUsername()
        {
            DB db = new DB();
            string username1 = textBoxusername.Text.Trim();
            MySqlConnection connection = db.getConnection();

            try
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM `users` WHERE `username` = @usn";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@usn", username1);

                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0; // Returns true if the username exists
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return false;
        }

        // check if the textboxes contains the default values
        public Boolean checkTextBoxesValues()
        {
            String fname = textBoxfirstname.Text;
            String lname = textBoxlastname.Text;
            String email = textBoxemailaddress.Text;
            String uname = textBoxusername.Text;
            String pass = textBoxpassword.Text;

            if (fname.Equals("first name") || lname.Equals("last name") ||
                email.Equals("email address") || uname.Equals("username")
                || pass.Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void textBoxfirstname_Enter(object sender, EventArgs e)
        {
            String fname = textBoxfirstname.Text;
            if (fname.ToLower().Trim().Equals("Firstname"))
            {
                textBoxfirstname.Text = "";
                textBoxfirstname.ForeColor = Color.Black;
            }
        }

        private void textBoxfirstname_Leave(object sender, EventArgs e)
        {
            String fname = textBoxfirstname.Text;
            if (string.IsNullOrWhiteSpace(fname) || fname.Equals("Firstname", StringComparison.OrdinalIgnoreCase))
            {
                textBoxfirstname.Text = "Firstname";
                textBoxfirstname.ForeColor = Color.Gray;
            }

        }

        private void textBoxlastname_Enter(object sender, EventArgs e)
        {
            String lname = textBoxlastname.Text;
            if (lname.ToLower().Trim().Equals("Lastname"))
            {
                textBoxlastname.Text = "";
                textBoxlastname.ForeColor = Color.Black;
            }
        }

        private void textBoxlastname_Leave(object sender, EventArgs e)
        {
            // Get the current text of the textbox
            String lname = textBoxlastname.Text;

            // Check if the textbox is empty or contains the default placeholder text
            if (string.IsNullOrWhiteSpace(lname) || lname.Equals("Lastname", StringComparison.OrdinalIgnoreCase))
            {
                // Reset the textbox to the placeholder and change text color to gray
                textBoxlastname.Text = "Lastname";
                textBoxlastname.ForeColor = Color.Gray;
            }
        }


        private void textBoxemailaddress_Enter(object sender, EventArgs e)
        {
            String ename = textBoxemailaddress.Text;
            if (ename.ToLower().Trim().Equals("Email Address"))
            {
                textBoxemailaddress.Text = "";
                textBoxemailaddress.ForeColor = Color.Black;
            }
        }

        private void textBoxemailaddress_Leave(object sender, EventArgs e)
        {
            // Get the current text from the textbox
            String ename = textBoxemailaddress.Text;

            // Check if the textbox is empty or contains the default placeholder text
            if (string.IsNullOrWhiteSpace(ename) || ename.Equals("Email Address", StringComparison.OrdinalIgnoreCase))
            {
                // Reset the textbox to the placeholder and set the text color to gray
                textBoxemailaddress.Text = "Email Address";
                textBoxemailaddress.ForeColor = Color.Gray;
            }
        }


        private void textBoxusername_Enter(object sender, EventArgs e)
        {
            String uname = textBoxusername.Text;
            if (uname.ToLower().Trim().Equals("Username"))
            {
                textBoxusername.Text = "";
                textBoxusername.ForeColor = Color.Black;
            }
        }

        private void textBoxusername_Leave(object sender, EventArgs e)
        {
            // Get the current text from the textbox
            String uname = textBoxusername.Text;

            // Check if the textbox is empty or contains the default placeholder text
            if (string.IsNullOrWhiteSpace(uname) || uname.Equals("Username", StringComparison.OrdinalIgnoreCase))
            {
                // Reset the textbox to the placeholder and set the text color to gray
                textBoxusername.Text = "Username";
                textBoxusername.ForeColor = Color.Gray;
            }
        }


        private void textBoxpassword_Enter(object sender, EventArgs e)
        {
            String pname = textBoxpassword.Text;
            if (pname.ToLower().Equals("Password"))
            {
                textBoxpassword.Text = "";
                textBoxpassword.ForeColor = Color.Black;
            }
        }

        private void textBoxpassword_Leave(object sender, EventArgs e)
        {
            // Get the current text from the password textbox
            String pname = textBoxpassword.Text;

            // Check if the textbox is empty or contains the placeholder "Password"
            if (string.IsNullOrWhiteSpace(pname) || pname.Equals("Password", StringComparison.OrdinalIgnoreCase))
            {
                // Reset the textbox to show the placeholder and set the text color to gray
                textBoxpassword.Text = "Password";
                textBoxpassword.ForeColor = Color.Gray;
            }
        }


        private void textBoxconfirmpassword_Enter(object sender, EventArgs e)
        {
            String cpname = textBoxconfirmpassword.Text;
            if (cpname.ToLower().Trim().Equals("Confirm Password"))
            {
                textBoxconfirmpassword.Text = "";
                textBoxconfirmpassword.UseSystemPasswordChar = true;
                textBoxconfirmpassword.ForeColor = Color.Black;
            }
        }

        private void textBoxconfirmpassword_Leave(object sender, EventArgs e)
        {
            String cpname = textBoxconfirmpassword.Text;
            if (string.IsNullOrWhiteSpace(cpname) || cpname.Equals("Confirm Password", StringComparison.OrdinalIgnoreCase))
            {
                textBoxconfirmpassword.Text = "Confirm Password";
                textBoxconfirmpassword.UseSystemPasswordChar = false;
                textBoxconfirmpassword.ForeColor = Color.Gray;
            }
        }

    }
}
