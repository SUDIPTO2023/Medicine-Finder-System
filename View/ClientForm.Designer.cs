namespace MedicineLocator.View
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            projectnameLabel = new Label();
            LogoutButton = new Button();
            ExitLabel = new Label();
            RegistrationClientAccountLabel = new Label();
            SearchButton = new Button();
            EditButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(projectnameLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 592);
            panel1.TabIndex = 29;
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
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.FromArgb(64, 0, 64);
            LogoutButton.Cursor = Cursors.Hand;
            LogoutButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutButton.ForeColor = Color.White;
            LogoutButton.Location = new Point(686, 553);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(165, 39);
            LogoutButton.TabIndex = 9;
            LogoutButton.Text = "Log Out";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Cursor = Cursors.Hand;
            ExitLabel.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitLabel.Location = new Point(827, 0);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(24, 24);
            ExitLabel.TabIndex = 30;
            ExitLabel.Text = "X";
            ExitLabel.Click += ExitLabel_Click;
            // 
            // RegistrationClientAccountLabel
            // 
            RegistrationClientAccountLabel.AutoSize = true;
            RegistrationClientAccountLabel.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegistrationClientAccountLabel.Location = new Point(375, 55);
            RegistrationClientAccountLabel.Name = "RegistrationClientAccountLabel";
            RegistrationClientAccountLabel.Size = new Size(438, 37);
            RegistrationClientAccountLabel.TabIndex = 31;
            RegistrationClientAccountLabel.Text = "Welcome Client Dashboard";
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.FromArgb(64, 0, 64);
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(467, 330);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(239, 39);
            SearchButton.TabIndex = 13;
            SearchButton.Text = "Search Medicine";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.FromArgb(64, 0, 64);
            EditButton.Cursor = Cursors.Hand;
            EditButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(467, 227);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(239, 39);
            EditButton.TabIndex = 14;
            EditButton.Text = "Edit Your Information";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 592);
            Controls.Add(SearchButton);
            Controls.Add(LogoutButton);
            Controls.Add(EditButton);
            Controls.Add(panel1);
            Controls.Add(ExitLabel);
            Controls.Add(RegistrationClientAccountLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button LogoutButton;
        private Label projectnameLabel;
        private Label ExitLabel;
        private Label RegistrationClientAccountLabel;
        private Button SearchButton;
        private Button EditButton;
    }
}