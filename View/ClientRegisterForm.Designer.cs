namespace MedicineLocator.View
{
    partial class ClientRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientRegisterForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            SignInButton = new Button();
            registerLabel = new Label();
            projectnameLabel = new Label();
            passwordCheckBox = new CheckBox();
            SignUpButton = new Button();
            passwordTextbox = new TextBox();
            IdTextbox = new TextBox();
            passwordLabel = new Label();
            idLabel = new Label();
            RegistrationClientAccountLabel = new Label();
            ExitLabel = new Label();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            GenderLabel = new Label();
            MaleRadioButton = new RadioButton();
            FemalRadioButton = new RadioButton();
            PhoneLabel = new Label();
            PhoneTextBox = new TextBox();
            EmailLabel = new Label();
            EmailTextBox = new TextBox();
            SecurityLabel = new Label();
            SecurityTextBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(353, 670);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 76);
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
            SignInButton.Location = new Point(23, 581);
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
            registerLabel.Location = new Point(66, 535);
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
            passwordCheckBox.Location = new Point(642, 538);
            passwordCheckBox.Name = "passwordCheckBox";
            passwordCheckBox.Size = new Size(161, 22);
            passwordCheckBox.TabIndex = 17;
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
            SignUpButton.Location = new Point(606, 598);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(126, 39);
            SignUpButton.TabIndex = 16;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(595, 485);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(208, 31);
            passwordTextbox.TabIndex = 15;
            passwordTextbox.UseSystemPasswordChar = true;
            // 
            // IdTextbox
            // 
            IdTextbox.Location = new Point(595, 124);
            IdTextbox.Name = "IdTextbox";
            IdTextbox.Size = new Size(208, 31);
            IdTextbox.TabIndex = 14;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(391, 485);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(98, 21);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idLabel.Location = new Point(391, 124);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 21);
            idLabel.TabIndex = 12;
            idLabel.Text = "Id";
            // 
            // RegistrationClientAccountLabel
            // 
            RegistrationClientAccountLabel.AutoSize = true;
            RegistrationClientAccountLabel.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegistrationClientAccountLabel.Location = new Point(543, 20);
            RegistrationClientAccountLabel.Name = "RegistrationClientAccountLabel";
            RegistrationClientAccountLabel.Size = new Size(248, 37);
            RegistrationClientAccountLabel.TabIndex = 11;
            RegistrationClientAccountLabel.Text = "Client Register";
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Cursor = Cursors.Hand;
            ExitLabel.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitLabel.Location = new Point(945, 0);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(24, 24);
            ExitLabel.TabIndex = 10;
            ExitLabel.Text = "X";
            ExitLabel.Click += ExitLabel_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(391, 188);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(62, 21);
            NameLabel.TabIndex = 18;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(595, 182);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(208, 31);
            NameTextBox.TabIndex = 19;
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenderLabel.Location = new Point(391, 243);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(76, 21);
            GenderLabel.TabIndex = 20;
            GenderLabel.Text = "Gender";
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaleRadioButton.Location = new Point(595, 243);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(77, 25);
            MaleRadioButton.TabIndex = 21;
            MaleRadioButton.TabStop = true;
            MaleRadioButton.Text = "Male";
            MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemalRadioButton
            // 
            FemalRadioButton.AutoSize = true;
            FemalRadioButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FemalRadioButton.Location = new Point(707, 243);
            FemalRadioButton.Name = "FemalRadioButton";
            FemalRadioButton.Size = new Size(100, 25);
            FemalRadioButton.TabIndex = 22;
            FemalRadioButton.TabStop = true;
            FemalRadioButton.Text = "Female";
            FemalRadioButton.UseVisualStyleBackColor = true;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneLabel.Location = new Point(391, 302);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(142, 21);
            PhoneLabel.TabIndex = 23;
            PhoneLabel.Text = "Phone Number";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(595, 296);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(208, 31);
            PhoneTextBox.TabIndex = 24;
            PhoneTextBox.TextChanged += PhoneTextBox_TextChanged;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailLabel.Location = new Point(391, 353);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(59, 21);
            EmailLabel.TabIndex = 25;
            EmailLabel.Text = "Email";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(595, 353);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(208, 31);
            EmailTextBox.TabIndex = 26;
            // 
            // SecurityLabel
            // 
            SecurityLabel.AutoSize = true;
            SecurityLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SecurityLabel.Location = new Point(394, 423);
            SecurityLabel.Name = "SecurityLabel";
            SecurityLabel.Size = new Size(157, 21);
            SecurityLabel.TabIndex = 27;
            SecurityLabel.Text = "Security Answer";
            // 
            // SecurityTextBox
            // 
            SecurityTextBox.Location = new Point(595, 417);
            SecurityTextBox.Name = "SecurityTextBox";
            SecurityTextBox.Size = new Size(208, 31);
            SecurityTextBox.TabIndex = 28;
            // 
            // ClientRegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 670);
            Controls.Add(SecurityTextBox);
            Controls.Add(SecurityLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(PhoneTextBox);
            Controls.Add(PhoneLabel);
            Controls.Add(FemalRadioButton);
            Controls.Add(MaleRadioButton);
            Controls.Add(GenderLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(panel1);
            Controls.Add(passwordCheckBox);
            Controls.Add(SignUpButton);
            Controls.Add(passwordTextbox);
            Controls.Add(IdTextbox);
            Controls.Add(passwordLabel);
            Controls.Add(idLabel);
            Controls.Add(RegistrationClientAccountLabel);
            Controls.Add(ExitLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientRegisterForm";
            Load += ClientRegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button SignInButton;
        private Label registerLabel;
        private Label projectnameLabel;
        private CheckBox passwordCheckBox;
        private Button SignUpButton;
        private TextBox passwordTextbox;
        private TextBox IdTextbox;
        private Label passwordLabel;
        private Label idLabel;
        private Label RegistrationClientAccountLabel;
        private Label ExitLabel;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label GenderLabel;
        private RadioButton MaleRadioButton;
        private RadioButton FemalRadioButton;
        private Label PhoneLabel;
        private TextBox PhoneTextBox;
        private Label EmailLabel;
        private TextBox EmailTextBox;
        private Label SecurityLabel;
        private TextBox SecurityTextBox;
        private PictureBox pictureBox1;
    }
}