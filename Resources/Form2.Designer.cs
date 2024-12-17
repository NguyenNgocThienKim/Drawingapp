namespace Drawingapp.Resources
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            Minimize1 = new Button();
            Close1 = new Button();
            panel2 = new Panel();
            textBoxconfirmpassword = new TextBox();
            textBoxpassword = new TextBox();
            textBoxusername = new TextBox();
            textBoxemailaddress = new TextBox();
            textBoxlastname = new TextBox();
            MOVETOFORM2 = new Label();
            createaccount = new Button();
            textBoxfirstname = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Minimize1);
            panel1.Controls.Add(Close1);
            panel1.Location = new Point(-2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1292, 139);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 15);
            label1.Name = "label1";
            label1.Size = new Size(858, 117);
            label1.TabIndex = 5;
            label1.Text = "Create Your Account";
            label1.Click += label1_Click_1;
            // 
            // Minimize1
            // 
            Minimize1.BackColor = Color.Transparent;
            Minimize1.BackgroundImage = Properties.Resources.line;
            Minimize1.BackgroundImageLayout = ImageLayout.Stretch;
            Minimize1.FlatAppearance.BorderSize = 0;
            Minimize1.FlatStyle = FlatStyle.Flat;
            Minimize1.Font = new Font("Mongolian Baiti", 24F);
            Minimize1.ImageAlign = ContentAlignment.TopCenter;
            Minimize1.Location = new Point(1125, 15);
            Minimize1.Name = "Minimize1";
            Minimize1.Size = new Size(59, 57);
            Minimize1.TabIndex = 4;
            Minimize1.UseVisualStyleBackColor = false;
            Minimize1.Click += Minimize1_Click;
            // 
            // Close1
            // 
            Close1.BackColor = Color.Transparent;
            Close1.BackgroundImage = Properties.Resources._111;
            Close1.BackgroundImageLayout = ImageLayout.Stretch;
            Close1.FlatAppearance.BorderSize = 0;
            Close1.FlatStyle = FlatStyle.Flat;
            Close1.Font = new Font("Mongolian Baiti", 24F);
            Close1.ImageAlign = ContentAlignment.TopCenter;
            Close1.Location = new Point(1218, 15);
            Close1.Name = "Close1";
            Close1.Size = new Size(59, 57);
            Close1.TabIndex = 3;
            Close1.UseVisualStyleBackColor = false;
            Close1.Click += Close1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(textBoxconfirmpassword);
            panel2.Controls.Add(textBoxpassword);
            panel2.Controls.Add(textBoxusername);
            panel2.Controls.Add(textBoxemailaddress);
            panel2.Controls.Add(textBoxlastname);
            panel2.Controls.Add(MOVETOFORM2);
            panel2.Controls.Add(createaccount);
            panel2.Controls.Add(textBoxfirstname);
            panel2.Location = new Point(-2, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(1289, 792);
            panel2.TabIndex = 1;
            // 
            // textBoxconfirmpassword
            // 
            textBoxconfirmpassword.Font = new Font("Calibri", 24F);
            textBoxconfirmpassword.ForeColor = Color.Gray;
            textBoxconfirmpassword.Location = new Point(72, 482);
            textBoxconfirmpassword.Multiline = true;
            textBoxconfirmpassword.Name = "textBoxconfirmpassword";
            textBoxconfirmpassword.PasswordChar = '*';
            textBoxconfirmpassword.Size = new Size(1147, 69);
            textBoxconfirmpassword.TabIndex = 23;
            textBoxconfirmpassword.Text = "Confirm Password";
            textBoxconfirmpassword.Enter += textBoxconfirmpassword_Enter;
            textBoxconfirmpassword.Leave += textBoxconfirmpassword_Leave;
            // 
            // textBoxpassword
            // 
            textBoxpassword.Font = new Font("Calibri", 24F);
            textBoxpassword.ForeColor = Color.Gray;
            textBoxpassword.Location = new Point(72, 368);
            textBoxpassword.Multiline = true;
            textBoxpassword.Name = "textBoxpassword";
            textBoxpassword.PasswordChar = '*';
            textBoxpassword.Size = new Size(1147, 69);
            textBoxpassword.TabIndex = 22;
            textBoxpassword.Text = "Password";
            textBoxpassword.Enter += textBoxpassword_Enter;
            textBoxpassword.Leave += textBoxpassword_Leave;
            // 
            // textBoxusername
            // 
            textBoxusername.Font = new Font("Calibri", 24F);
            textBoxusername.ForeColor = Color.Gray;
            textBoxusername.Location = new Point(72, 257);
            textBoxusername.Multiline = true;
            textBoxusername.Name = "textBoxusername";
            textBoxusername.Size = new Size(1147, 69);
            textBoxusername.TabIndex = 21;
            textBoxusername.Text = "Username";
            textBoxusername.Enter += textBoxusername_Enter;
            textBoxusername.Leave += textBoxusername_Leave;
            // 
            // textBoxemailaddress
            // 
            textBoxemailaddress.Font = new Font("Calibri", 24F);
            textBoxemailaddress.ForeColor = Color.Gray;
            textBoxemailaddress.Location = new Point(72, 145);
            textBoxemailaddress.Multiline = true;
            textBoxemailaddress.Name = "textBoxemailaddress";
            textBoxemailaddress.Size = new Size(1147, 69);
            textBoxemailaddress.TabIndex = 20;
            textBoxemailaddress.Text = "Email Address";
            textBoxemailaddress.Enter += textBoxemailaddress_Enter;
            textBoxemailaddress.Leave += textBoxemailaddress_Leave;
            // 
            // textBoxlastname
            // 
            textBoxlastname.Font = new Font("Calibri", 24F);
            textBoxlastname.ForeColor = Color.Gray;
            textBoxlastname.Location = new Point(671, 31);
            textBoxlastname.Multiline = true;
            textBoxlastname.Name = "textBoxlastname";
            textBoxlastname.Size = new Size(548, 69);
            textBoxlastname.TabIndex = 19;
            textBoxlastname.Text = "Lastname";
            textBoxlastname.Enter += textBoxlastname_Enter;
            textBoxlastname.Leave += textBoxlastname_Leave;
            // 
            // MOVETOFORM2
            // 
            MOVETOFORM2.AutoSize = true;
            MOVETOFORM2.BackColor = Color.Transparent;
            MOVETOFORM2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MOVETOFORM2.ForeColor = SystemColors.ButtonHighlight;
            MOVETOFORM2.Location = new Point(550, 702);
            MOVETOFORM2.Name = "MOVETOFORM2";
            MOVETOFORM2.Size = new Size(332, 29);
            MOVETOFORM2.TabIndex = 18;
            MOVETOFORM2.Text = "Already have an account? Log in";
            MOVETOFORM2.Click += MOVETOFORM2_Click;
            // 
            // createaccount
            // 
            createaccount.BackColor = Color.FromArgb(218, 103, 32);
            createaccount.FlatAppearance.BorderSize = 0;
            createaccount.FlatStyle = FlatStyle.Popup;
            createaccount.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createaccount.Location = new Point(480, 604);
            createaccount.Name = "createaccount";
            createaccount.Size = new Size(467, 76);
            createaccount.TabIndex = 17;
            createaccount.Text = "CREATE ACCOUNT";
            createaccount.UseVisualStyleBackColor = false;
            createaccount.Click += createaccount_Click;
            // 
            // textBoxfirstname
            // 
            textBoxfirstname.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxfirstname.ForeColor = Color.Gray;
            textBoxfirstname.Location = new Point(72, 31);
            textBoxfirstname.Multiline = true;
            textBoxfirstname.Name = "textBoxfirstname";
            textBoxfirstname.Size = new Size(548, 69);
            textBoxfirstname.TabIndex = 6;
            textBoxfirstname.Text = "Firstname";
            textBoxfirstname.Enter += textBoxfirstname_Enter;
            textBoxfirstname.Leave += textBoxfirstname_Leave;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 922);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Minimize1;
        private Button Close1;
        private Label label1;
        private Panel panel2;
        private TextBox textBoxfirstname;
        private Button createaccount;
        private Label MOVETOFORM2;
        private TextBox textBoxlastname;
        private TextBox textBoxconfirmpassword;
        private TextBox textBoxpassword;
        private TextBox textBoxusername;
        private TextBox textBoxemailaddress;
    }
}