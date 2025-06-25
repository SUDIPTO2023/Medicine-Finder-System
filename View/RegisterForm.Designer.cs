namespace MedicineLocator.View
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            UserListCombobox = new ComboBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            registerLabel = new Label();
            projectnameLabel = new Label();
            NextButton = new Button();
            RegisterAccountLabel = new Label();
            exitLabel = new Label();
            exitLabel2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UserListCombobox
            // 
            UserListCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            UserListCombobox.FormattingEnabled = true;
            UserListCombobox.Items.AddRange(new object[] { "Client", "Manager" });
            UserListCombobox.Location = new Point(380, 255);
            UserListCombobox.Name = "UserListCombobox";
            UserListCombobox.Size = new Size(229, 33);
            UserListCombobox.TabIndex = 20;
            UserListCombobox.SelectedIndexChanged += UserListCombobox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(registerLabel);
            panel1.Controls.Add(projectnameLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 605);
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
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerLabel.ForeColor = Color.WhiteSmoke;
            registerLabel.Location = new Point(54, 547);
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
            // NextButton
            // 
            NextButton.BackColor = Color.FromArgb(64, 0, 64);
            NextButton.Cursor = Cursors.Hand;
            NextButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NextButton.ForeColor = Color.White;
            NextButton.Location = new Point(380, 336);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(192, 39);
            NextButton.TabIndex = 9;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += NextButton_Click;
            // 
            // RegisterAccountLabel
            // 
            RegisterAccountLabel.AutoSize = true;
            RegisterAccountLabel.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterAccountLabel.Location = new Point(422, 90);
            RegisterAccountLabel.Name = "RegisterAccountLabel";
            RegisterAccountLabel.Size = new Size(187, 46);
            RegisterAccountLabel.TabIndex = 11;
            RegisterAccountLabel.Text = "Register";
            RegisterAccountLabel.Click += RegisterAccountLabel_Click;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitLabel.Location = new Point(673, -22);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(24, 24);
            exitLabel.TabIndex = 10;
            exitLabel.Text = "X";
            // 
            // exitLabel2
            // 
            exitLabel2.AutoSize = true;
            exitLabel2.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitLabel2.Location = new Point(684, 0);
            exitLabel2.Name = "exitLabel2";
            exitLabel2.Size = new Size(27, 27);
            exitLabel2.TabIndex = 19;
            exitLabel2.Text = "X";
            exitLabel2.Click += exitLabel2_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 605);
            Controls.Add(UserListCombobox);
            Controls.Add(exitLabel2);
            Controls.Add(NextButton);
            Controls.Add(panel1);
            Controls.Add(RegisterAccountLabel);
            Controls.Add(exitLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button NextButton;
        private Label registerLabel;
        private Label projectnameLabel;
        private Label RegisterAccountLabel;
        private Label exitLabel;
        private Label exitLabel2;
        private ComboBox UserListCombobox;
    }
}