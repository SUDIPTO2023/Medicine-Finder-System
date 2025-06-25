namespace MedicineLocator.View
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            signupButton = new Button();
            registerLabel = new Label();
            projectnameLabel = new Label();
            exitLabel = new Label();
            loginAccountLabel = new Label();
            idLabel = new Label();
            passwordLabel = new Label();
            idTextbox = new TextBox();
            passwordTextbox = new TextBox();
            loginButton = new Button();
            passwordCheckBox = new CheckBox();
            ForgetButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(signupButton);
            panel1.Controls.Add(registerLabel);
            panel1.Controls.Add(projectnameLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 605);
            panel1.TabIndex = 0;
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
            // signupButton
            // 
            signupButton.BackColor = Color.FromArgb(64, 0, 64);
            signupButton.Cursor = Cursors.Hand;
            signupButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupButton.ForeColor = Color.White;
            signupButton.Location = new Point(23, 550);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(289, 39);
            signupButton.TabIndex = 9;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += signupButton_Click;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerLabel.ForeColor = Color.WhiteSmoke;
            registerLabel.Location = new Point(56, 509);
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
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitLabel.Location = new Point(684, 0);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(24, 24);
            exitLabel.TabIndex = 1;
            exitLabel.Text = "X";
            exitLabel.Click += exitLabel_Click;
            // 
            // loginAccountLabel
            // 
            loginAccountLabel.AutoSize = true;
            loginAccountLabel.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginAccountLabel.Location = new Point(391, 127);
            loginAccountLabel.Name = "loginAccountLabel";
            loginAccountLabel.Size = new Size(240, 37);
            loginAccountLabel.TabIndex = 2;
            loginAccountLabel.Text = "Login Account";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idLabel.Location = new Point(391, 277);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 21);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(391, 371);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(98, 21);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // idTextbox
            // 
            idTextbox.Location = new Point(391, 311);
            idTextbox.Name = "idTextbox";
            idTextbox.Size = new Size(278, 31);
            idTextbox.TabIndex = 5;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(391, 411);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(278, 31);
            passwordTextbox.TabIndex = 6;
            passwordTextbox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(64, 0, 64);
            loginButton.Cursor = Cursors.Hand;
            loginButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(451, 566);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(126, 39);
            loginButton.TabIndex = 7;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordCheckBox
            // 
            passwordCheckBox.AutoSize = true;
            passwordCheckBox.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordCheckBox.Location = new Point(508, 448);
            passwordCheckBox.Name = "passwordCheckBox";
            passwordCheckBox.Size = new Size(161, 22);
            passwordCheckBox.TabIndex = 8;
            passwordCheckBox.Text = "Show Password";
            passwordCheckBox.UseVisualStyleBackColor = true;
            passwordCheckBox.CheckedChanged += passwordCheckBox_CheckedChanged;
            // 
            // ForgetButton
            // 
            ForgetButton.BackColor = Color.White;
            ForgetButton.Cursor = Cursors.Hand;
            ForgetButton.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForgetButton.ForeColor = Color.Black;
            ForgetButton.Location = new Point(380, 476);
            ForgetButton.Name = "ForgetButton";
            ForgetButton.Size = new Size(289, 35);
            ForgetButton.TabIndex = 9;
            ForgetButton.Text = "Forget Password";
            ForgetButton.UseVisualStyleBackColor = false;
            ForgetButton.Click += ForgetButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(708, 605);
            Controls.Add(ForgetButton);
            Controls.Add(passwordCheckBox);
            Controls.Add(loginButton);
            Controls.Add(passwordTextbox);
            Controls.Add(idTextbox);
            Controls.Add(passwordLabel);
            Controls.Add(idLabel);
            Controls.Add(loginAccountLabel);
            Controls.Add(exitLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exitLabel;
        private Label loginAccountLabel;
        private Label idLabel;
        private Label passwordLabel;
        private TextBox idTextbox;
        private TextBox passwordTextbox;
        private Button loginButton;
        private CheckBox passwordCheckBox;
        private Label projectnameLabel;
        private Button signupButton;
        private Label registerLabel;
        private PictureBox pictureBox1;
        private Button ForgetButton;
    }
}