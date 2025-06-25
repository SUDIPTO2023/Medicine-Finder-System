namespace MedicineLocator.View
{
    partial class ManagerRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerRegisterForm));
            SecurityTextBox = new TextBox();
            SecurityLabel = new Label();
            EmailTextBox = new TextBox();
            EmailLabel = new Label();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            SignInButton = new Button();
            registerLabel = new Label();
            projectnameLabel = new Label();
            passwordCheckBox = new CheckBox();
            SignUpButton = new Button();
            passwordTextbox = new TextBox();
            IdTextbox = new TextBox();
            LisenceLabel = new Label();
            ExitLabel = new Label();
            idLabel = new Label();
            RegistrationManagerAccountLabel = new Label();
            PharmacyLabel = new Label();
            LisenceTextBox = new TextBox();
            PasswordLabel = new Label();
            LocationTextBox = new TextBox();
            LocationLabel = new Label();
            PharmacyNameTextBox = new TextBox();
            PharmacyNameLabel = new Label();
            PharmacyTextBox = new TextBox();
            PharmacyIdLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SecurityTextBox
            // 
            SecurityTextBox.Location = new Point(608, 586);
            SecurityTextBox.Name = "SecurityTextBox";
            SecurityTextBox.Size = new Size(208, 31);
            SecurityTextBox.TabIndex = 48;
            SecurityTextBox.TextChanged += SecurityTextBox_TextChanged;
            // 
            // SecurityLabel
            // 
            SecurityLabel.AutoSize = true;
            SecurityLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecurityLabel.Location = new Point(407, 592);
            SecurityLabel.Name = "SecurityLabel";
            SecurityLabel.Size = new Size(157, 21);
            SecurityLabel.TabIndex = 47;
            SecurityLabel.Text = "Security Answer";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(597, 263);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(208, 31);
            EmailTextBox.TabIndex = 46;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailLabel.Location = new Point(396, 263);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(59, 21);
            EmailLabel.TabIndex = 45;
            EmailLabel.Text = "Email";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(597, 209);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(208, 31);
            PhoneTextBox.TabIndex = 44;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneLabel.Location = new Point(393, 215);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(142, 21);
            PhoneLabel.TabIndex = 43;
            PhoneLabel.Text = "Phone Number";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(597, 157);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(208, 31);
            NameTextBox.TabIndex = 39;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(393, 163);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(62, 21);
            NameLabel.TabIndex = 38;
            NameLabel.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(SignInButton);
            panel1.Controls.Add(registerLabel);
            panel1.Controls.Add(projectnameLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 759);
            panel1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 157);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // SignInButton
            // 
            SignInButton.BackColor = Color.FromArgb(64, 0, 64);
            SignInButton.Cursor = Cursors.Hand;
            SignInButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignInButton.ForeColor = Color.White;
            SignInButton.Location = new Point(23, 627);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(289, 39);
            SignInButton.TabIndex = 9;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerLabel.ForeColor = Color.WhiteSmoke;
            registerLabel.Location = new Point(66, 557);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(210, 21);
            registerLabel.TabIndex = 10;
            registerLabel.Text = "Register Your Account";
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
            passwordCheckBox.Location = new Point(655, 714);
            passwordCheckBox.Name = "passwordCheckBox";
            passwordCheckBox.Size = new Size(161, 22);
            passwordCheckBox.TabIndex = 37;
            passwordCheckBox.Text = "Show Password";
            passwordCheckBox.UseVisualStyleBackColor = true;
            passwordCheckBox.CheckedChanged += passwordCheckBox_CheckedChanged;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.FromArgb(64, 0, 64);
            SignUpButton.Cursor = Cursors.Hand;
            SignUpButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUpButton.ForeColor = Color.White;
            SignUpButton.Location = new Point(994, 703);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(126, 39);
            SignUpButton.TabIndex = 36;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(608, 659);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(208, 31);
            passwordTextbox.TabIndex = 35;
            passwordTextbox.UseSystemPasswordChar = true;
            // 
            // IdTextbox
            // 
            IdTextbox.Location = new Point(597, 102);
            IdTextbox.Name = "IdTextbox";
            IdTextbox.Size = new Size(208, 31);
            IdTextbox.TabIndex = 34;
            // 
            // LisenceLabel
            // 
            LisenceLabel.AutoSize = true;
            LisenceLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LisenceLabel.Location = new Point(407, 543);
            LisenceLabel.Name = "LisenceLabel";
            LisenceLabel.Size = new Size(156, 21);
            LisenceLabel.TabIndex = 33;
            LisenceLabel.Text = "Lisence Number";
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Cursor = Cursors.Hand;
            ExitLabel.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitLabel.Location = new Point(1106, 0);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(24, 24);
            ExitLabel.TabIndex = 30;
            ExitLabel.Text = "X";
            ExitLabel.Click += ExitLabel_Click;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idLabel.Location = new Point(393, 102);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 21);
            idLabel.TabIndex = 32;
            idLabel.Text = "Id";
            // 
            // RegistrationManagerAccountLabel
            // 
            RegistrationManagerAccountLabel.AutoSize = true;
            RegistrationManagerAccountLabel.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegistrationManagerAccountLabel.Location = new Point(558, 18);
            RegistrationManagerAccountLabel.Name = "RegistrationManagerAccountLabel";
            RegistrationManagerAccountLabel.Size = new Size(294, 37);
            RegistrationManagerAccountLabel.TabIndex = 31;
            RegistrationManagerAccountLabel.Text = "Manager Register";
            // 
            // PharmacyLabel
            // 
            PharmacyLabel.AutoSize = true;
            PharmacyLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PharmacyLabel.Location = new Point(518, 318);
            PharmacyLabel.Name = "PharmacyLabel";
            PharmacyLabel.Size = new Size(376, 28);
            PharmacyLabel.TabIndex = 49;
            PharmacyLabel.Text = "Give The Pharmacy Information";
            // 
            // LisenceTextBox
            // 
            LisenceTextBox.Location = new Point(608, 537);
            LisenceTextBox.Name = "LisenceTextBox";
            LisenceTextBox.Size = new Size(208, 31);
            LisenceTextBox.TabIndex = 57;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(417, 665);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(98, 21);
            PasswordLabel.TabIndex = 56;
            PasswordLabel.Text = "Password";
            // 
            // LocationTextBox
            // 
            LocationTextBox.Location = new Point(608, 483);
            LocationTextBox.Name = "LocationTextBox";
            LocationTextBox.Size = new Size(208, 31);
            LocationTextBox.TabIndex = 55;
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LocationLabel.Location = new Point(407, 489);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(87, 21);
            LocationLabel.TabIndex = 54;
            LocationLabel.Text = "Location";
            // 
            // PharmacyNameTextBox
            // 
            PharmacyNameTextBox.Location = new Point(608, 431);
            PharmacyNameTextBox.Name = "PharmacyNameTextBox";
            PharmacyNameTextBox.Size = new Size(208, 31);
            PharmacyNameTextBox.TabIndex = 53;
            // 
            // PharmacyNameLabel
            // 
            PharmacyNameLabel.AutoSize = true;
            PharmacyNameLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PharmacyNameLabel.Location = new Point(404, 437);
            PharmacyNameLabel.Name = "PharmacyNameLabel";
            PharmacyNameLabel.Size = new Size(157, 21);
            PharmacyNameLabel.TabIndex = 52;
            PharmacyNameLabel.Text = "Pharmacy Name";
            // 
            // PharmacyTextBox
            // 
            PharmacyTextBox.BackColor = SystemColors.HighlightText;
            PharmacyTextBox.Location = new Point(608, 376);
            PharmacyTextBox.Name = "PharmacyTextBox";
            PharmacyTextBox.Size = new Size(208, 31);
            PharmacyTextBox.TabIndex = 51;
            // 
            // PharmacyIdLabel
            // 
            PharmacyIdLabel.AutoSize = true;
            PharmacyIdLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PharmacyIdLabel.Location = new Point(404, 376);
            PharmacyIdLabel.Name = "PharmacyIdLabel";
            PharmacyIdLabel.Size = new Size(122, 21);
            PharmacyIdLabel.TabIndex = 50;
            PharmacyIdLabel.Text = "Pharmacy Id";
            // 
            // ManagerRegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1132, 759);
            Controls.Add(LisenceTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(LocationTextBox);
            Controls.Add(LocationLabel);
            Controls.Add(PharmacyNameTextBox);
            Controls.Add(PharmacyNameLabel);
            Controls.Add(PharmacyTextBox);
            Controls.Add(PharmacyIdLabel);
            Controls.Add(PharmacyLabel);
            Controls.Add(SecurityTextBox);
            Controls.Add(SecurityLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(PhoneTextBox);
            Controls.Add(PhoneLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(panel1);
            Controls.Add(passwordCheckBox);
            Controls.Add(SignUpButton);
            Controls.Add(passwordTextbox);
            Controls.Add(IdTextbox);
            Controls.Add(LisenceLabel);
            Controls.Add(ExitLabel);
            Controls.Add(idLabel);
            Controls.Add(RegistrationManagerAccountLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagerRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerRegisterForm";
            Load += ManagerRegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SecurityTextBox;
        private Label SecurityLabel;
        private TextBox EmailTextBox;
        private Label EmailLabel;
        private TextBox PhoneTextBox;
        private Label PhoneLabel;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Panel panel1;
        private Button SignInButton;
        private Label registerLabel;
        private Label projectnameLabel;
        private CheckBox passwordCheckBox;
        private Button SignUpButton;
        private TextBox passwordTextbox;
        private TextBox IdTextbox;
        private Label LisenceLabel;
        private Label ExitLabel;
        private Label idLabel;
        private Label RegistrationManagerAccountLabel;
        private Label PharmacyLabel;
        private TextBox LisenceTextBox;
        private Label PasswordLabel;
        private TextBox LocationTextBox;
        private Label LocationLabel;
        private TextBox PharmacyNameTextBox;
        private Label PharmacyNameLabel;
        private TextBox PharmacyTextBox;
        private Label PharmacyIdLabel;
        private PictureBox pictureBox1;
    }
}