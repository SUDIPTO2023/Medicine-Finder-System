namespace MedicineLocator.View
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            BackButton = new Button();
            projectnameLabel = new Label();
            passwordCheckBox = new CheckBox();
            SaveButton = new Button();
            NewpasswordTextbox = new TextBox();
            SecurityTextbox = new TextBox();
            NewPasswordLabel = new Label();
            SecurityAnswerLabel = new Label();
            loginAccountLabel = new Label();
            exitLabel = new Label();
            UserIdLabel = new Label();
            IdtextBox = new TextBox();
            EmailLabel = new Label();
            MailTextBox = new TextBox();
            SendOtpButton = new Button();
            OTPLabel = new Label();
            OTPTextBox = new TextBox();
            VerifyButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(projectnameLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 598);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 157);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(64, 0, 64);
            BackButton.Cursor = Cursors.Hand;
            BackButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(23, 550);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(289, 39);
            BackButton.TabIndex = 9;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // projectnameLabel
            // 
            projectnameLabel.AutoSize = true;
            projectnameLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectnameLabel.ForeColor = Color.WhiteSmoke;
            projectnameLabel.Location = new Point(23, 275);
            projectnameLabel.Name = "projectnameLabel";
            projectnameLabel.Size = new Size(289, 28);
            projectnameLabel.TabIndex = 9;
            projectnameLabel.Text = "Medicine Finder System";
            // 
            // passwordCheckBox
            // 
            passwordCheckBox.AutoSize = true;
            passwordCheckBox.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordCheckBox.Location = new Point(669, 490);
            passwordCheckBox.Name = "passwordCheckBox";
            passwordCheckBox.Size = new Size(161, 22);
            passwordCheckBox.TabIndex = 17;
            passwordCheckBox.Text = "Show Password";
            passwordCheckBox.UseVisualStyleBackColor = true;
            passwordCheckBox.CheckedChanged += passwordCheckBox_CheckedChanged;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(64, 0, 64);
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(578, 535);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(126, 39);
            SaveButton.TabIndex = 16;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // NewpasswordTextbox
            // 
            NewpasswordTextbox.Location = new Point(552, 435);
            NewpasswordTextbox.Name = "NewpasswordTextbox";
            NewpasswordTextbox.Size = new Size(278, 31);
            NewpasswordTextbox.TabIndex = 15;
            NewpasswordTextbox.UseSystemPasswordChar = true;
            // 
            // SecurityTextbox
            // 
            SecurityTextbox.Location = new Point(552, 366);
            SecurityTextbox.Name = "SecurityTextbox";
            SecurityTextbox.PlaceholderText = " ";
            SecurityTextbox.Size = new Size(278, 31);
            SecurityTextbox.TabIndex = 14;
            SecurityTextbox.Tag = " ";
            SecurityTextbox.Text = " ";
            // 
            // NewPasswordLabel
            // 
            NewPasswordLabel.AutoSize = true;
            NewPasswordLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewPasswordLabel.Location = new Point(354, 441);
            NewPasswordLabel.Name = "NewPasswordLabel";
            NewPasswordLabel.Size = new Size(143, 21);
            NewPasswordLabel.TabIndex = 13;
            NewPasswordLabel.Text = "New Password";
            // 
            // SecurityAnswerLabel
            // 
            SecurityAnswerLabel.AutoSize = true;
            SecurityAnswerLabel.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecurityAnswerLabel.Location = new Point(354, 370);
            SecurityAnswerLabel.Name = "SecurityAnswerLabel";
            SecurityAnswerLabel.Size = new Size(170, 23);
            SecurityAnswerLabel.TabIndex = 12;
            SecurityAnswerLabel.Text = "Security Answer";
            // 
            // loginAccountLabel
            // 
            loginAccountLabel.AutoSize = true;
            loginAccountLabel.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginAccountLabel.Location = new Point(516, 9);
            loginAccountLabel.Name = "loginAccountLabel";
            loginAccountLabel.Size = new Size(267, 37);
            loginAccountLabel.TabIndex = 11;
            loginAccountLabel.Text = "Reset Password";
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitLabel.Location = new Point(914, 0);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(24, 24);
            exitLabel.TabIndex = 10;
            exitLabel.Text = "X";
            exitLabel.Click += exitLabel_Click;
            // 
            // UserIdLabel
            // 
            UserIdLabel.AutoSize = true;
            UserIdLabel.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserIdLabel.Location = new Point(354, 320);
            UserIdLabel.Name = "UserIdLabel";
            UserIdLabel.Size = new Size(81, 23);
            UserIdLabel.TabIndex = 18;
            UserIdLabel.Text = "User Id";
            // 
            // IdtextBox
            // 
            IdtextBox.Location = new Point(552, 316);
            IdtextBox.Name = "IdtextBox";
            IdtextBox.Size = new Size(278, 31);
            IdtextBox.TabIndex = 19;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailLabel.Location = new Point(354, 127);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(63, 23);
            EmailLabel.TabIndex = 20;
            EmailLabel.Text = "Email";
            // 
            // MailTextBox
            // 
            MailTextBox.Location = new Point(552, 119);
            MailTextBox.Name = "MailTextBox";
            MailTextBox.Size = new Size(278, 31);
            MailTextBox.TabIndex = 21;
            // 
            // SendOtpButton
            // 
            SendOtpButton.BackColor = Color.White;
            SendOtpButton.Cursor = Cursors.Hand;
            SendOtpButton.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SendOtpButton.ForeColor = Color.Black;
            SendOtpButton.Location = new Point(704, 156);
            SendOtpButton.Name = "SendOtpButton";
            SendOtpButton.Size = new Size(126, 26);
            SendOtpButton.TabIndex = 22;
            SendOtpButton.Text = "Send OTP";
            SendOtpButton.UseVisualStyleBackColor = false;
            SendOtpButton.Click += SendOtpButton_Click;
            // 
            // OTPLabel
            // 
            OTPLabel.AutoSize = true;
            OTPLabel.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OTPLabel.Location = new Point(354, 216);
            OTPLabel.Name = "OTPLabel";
            OTPLabel.Size = new Size(52, 23);
            OTPLabel.TabIndex = 23;
            OTPLabel.Text = "OTP";
            // 
            // OTPTextBox
            // 
            OTPTextBox.Location = new Point(552, 216);
            OTPTextBox.Name = "OTPTextBox";
            OTPTextBox.Size = new Size(278, 31);
            OTPTextBox.TabIndex = 24;
            // 
            // VerifyButton
            // 
            VerifyButton.BackColor = Color.White;
            VerifyButton.Cursor = Cursors.Hand;
            VerifyButton.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VerifyButton.ForeColor = Color.Black;
            VerifyButton.Location = new Point(704, 253);
            VerifyButton.Name = "VerifyButton";
            VerifyButton.Size = new Size(126, 29);
            VerifyButton.TabIndex = 25;
            VerifyButton.Text = "Verify OTP";
            VerifyButton.UseVisualStyleBackColor = false;
            VerifyButton.Click += VerifyButton_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 598);
            Controls.Add(VerifyButton);
            Controls.Add(OTPTextBox);
            Controls.Add(OTPLabel);
            Controls.Add(SendOtpButton);
            Controls.Add(MailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(IdtextBox);
            Controls.Add(UserIdLabel);
            Controls.Add(panel1);
            Controls.Add(passwordCheckBox);
            Controls.Add(SaveButton);
            Controls.Add(NewpasswordTextbox);
            Controls.Add(SecurityTextbox);
            Controls.Add(NewPasswordLabel);
            Controls.Add(SecurityAnswerLabel);
            Controls.Add(loginAccountLabel);
            Controls.Add(exitLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordForm";
            Load += ForgotPasswordForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button BackButton;
        private Label projectnameLabel;
        private CheckBox passwordCheckBox;
        private Button SaveButton;
        private TextBox NewpasswordTextbox;
        private TextBox SecurityTextbox;
        private Label NewPasswordLabel;
        private Label SecurityAnswerLabel;
        private Label loginAccountLabel;
        private Label exitLabel;
        private Label UserIdLabel;
        private TextBox IdtextBox;
        private Label EmailLabel;
        private TextBox MailTextBox;
        private Button SendOtpButton;
        private Label OTPLabel;
        private TextBox OTPTextBox;
        private Button VerifyButton;
    }
}