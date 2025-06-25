namespace MedicineLocator.View
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            RegistrationManagerAccountLabel = new Label();
            ExitLabel = new Label();
            projectnameLabel = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            UserControlLabel = new Label();
            PharmacyManagementButton = new Button();
            ClientManagementButton = new Button();
            ManagerManagementButton = new Button();
            ManagerListLable = new Label();
            PharmacyListLabel = new Label();
            ClientLIstLabel = new Label();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // RegistrationManagerAccountLabel
            // 
            RegistrationManagerAccountLabel.AutoSize = true;
            RegistrationManagerAccountLabel.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegistrationManagerAccountLabel.Location = new Point(709, 0);
            RegistrationManagerAccountLabel.Name = "RegistrationManagerAccountLabel";
            RegistrationManagerAccountLabel.Size = new Size(288, 46);
            RegistrationManagerAccountLabel.TabIndex = 100;
            RegistrationManagerAccountLabel.Text = "Admin Pannel";
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Cursor = Cursors.Hand;
            ExitLabel.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitLabel.Location = new Point(1335, 0);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(24, 24);
            ExitLabel.TabIndex = 99;
            ExitLabel.Text = "X";
            ExitLabel.Click += ExitLabel_Click;
            // 
            // projectnameLabel
            // 
            projectnameLabel.AutoSize = true;
            projectnameLabel.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectnameLabel.ForeColor = Color.Transparent;
            projectnameLabel.Location = new Point(10, 233);
            projectnameLabel.Name = "projectnameLabel";
            projectnameLabel.Size = new Size(343, 32);
            projectnameLabel.TabIndex = 9;
            projectnameLabel.Text = "Medicine Finder System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 157);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(UserControlLabel);
            panel1.Controls.Add(PharmacyManagementButton);
            panel1.Controls.Add(ClientManagementButton);
            panel1.Controls.Add(ManagerManagementButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(projectnameLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 719);
            panel1.TabIndex = 98;
            // 
            // UserControlLabel
            // 
            UserControlLabel.AutoSize = true;
            UserControlLabel.BackColor = Color.FromArgb(64, 0, 64);
            UserControlLabel.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserControlLabel.ForeColor = Color.Transparent;
            UserControlLabel.Location = new Point(39, 342);
            UserControlLabel.Name = "UserControlLabel";
            UserControlLabel.Size = new Size(243, 42);
            UserControlLabel.TabIndex = 125;
            UserControlLabel.Text = "User Control";
            // 
            // PharmacyManagementButton
            // 
            PharmacyManagementButton.BackColor = Color.FromArgb(64, 0, 64);
            PharmacyManagementButton.Cursor = Cursors.Hand;
            PharmacyManagementButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PharmacyManagementButton.ForeColor = Color.White;
            PharmacyManagementButton.Location = new Point(41, 485);
            PharmacyManagementButton.Name = "PharmacyManagementButton";
            PharmacyManagementButton.Size = new Size(241, 39);
            PharmacyManagementButton.TabIndex = 95;
            PharmacyManagementButton.Text = "Pharmacy Management";
            PharmacyManagementButton.UseVisualStyleBackColor = false;
            PharmacyManagementButton.Click += PharmacyManagementButton_Click;
            // 
            // ClientManagementButton
            // 
            ClientManagementButton.BackColor = Color.FromArgb(64, 0, 64);
            ClientManagementButton.Cursor = Cursors.Hand;
            ClientManagementButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClientManagementButton.ForeColor = Color.White;
            ClientManagementButton.Location = new Point(41, 546);
            ClientManagementButton.Name = "ClientManagementButton";
            ClientManagementButton.Size = new Size(241, 38);
            ClientManagementButton.TabIndex = 94;
            ClientManagementButton.Text = "Client Management";
            ClientManagementButton.UseVisualStyleBackColor = false;
            ClientManagementButton.Click += ClientManagementButton_Click;
            // 
            // ManagerManagementButton
            // 
            ManagerManagementButton.BackColor = Color.FromArgb(64, 0, 64);
            ManagerManagementButton.Cursor = Cursors.Hand;
            ManagerManagementButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ManagerManagementButton.ForeColor = Color.White;
            ManagerManagementButton.Location = new Point(41, 425);
            ManagerManagementButton.Name = "ManagerManagementButton";
            ManagerManagementButton.Size = new Size(241, 37);
            ManagerManagementButton.TabIndex = 93;
            ManagerManagementButton.Text = "Manager Management";
            ManagerManagementButton.UseVisualStyleBackColor = false;
            ManagerManagementButton.Click += ManagerManagementButton_Click;
            // 
            // ManagerListLable
            // 
            ManagerListLable.AutoSize = true;
            ManagerListLable.BackColor = Color.FromArgb(64, 0, 64);
            ManagerListLable.Cursor = Cursors.Hand;
            ManagerListLable.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ManagerListLable.ForeColor = Color.WhiteSmoke;
            ManagerListLable.Location = new Point(416, 118);
            ManagerListLable.Name = "ManagerListLable";
            ManagerListLable.Size = new Size(266, 32);
            ManagerListLable.TabIndex = 13;
            ManagerListLable.Text = "View Manager List";
            ManagerListLable.Click += ManagerListLable_Click;
            // 
            // PharmacyListLabel
            // 
            PharmacyListLabel.AutoSize = true;
            PharmacyListLabel.BackColor = Color.FromArgb(64, 0, 64);
            PharmacyListLabel.Cursor = Cursors.Hand;
            PharmacyListLabel.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PharmacyListLabel.ForeColor = Color.WhiteSmoke;
            PharmacyListLabel.Location = new Point(740, 118);
            PharmacyListLabel.Name = "PharmacyListLabel";
            PharmacyListLabel.Size = new Size(284, 32);
            PharmacyListLabel.TabIndex = 122;
            PharmacyListLabel.Text = "View Pharmacy List";
            PharmacyListLabel.Click += PharmacyListLabel_Click;
            // 
            // ClientLIstLabel
            // 
            ClientLIstLabel.AutoSize = true;
            ClientLIstLabel.BackColor = Color.FromArgb(64, 0, 64);
            ClientLIstLabel.Cursor = Cursors.Hand;
            ClientLIstLabel.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClientLIstLabel.ForeColor = Color.WhiteSmoke;
            ClientLIstLabel.Location = new Point(1101, 118);
            ClientLIstLabel.Name = "ClientLIstLabel";
            ClientLIstLabel.Size = new Size(226, 32);
            ClientLIstLabel.TabIndex = 123;
            ClientLIstLabel.Text = "View Client List";
            ClientLIstLabel.Click += ClientLIstLabel_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = Color.Plum;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.DarkMagenta;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.GridColor = Color.FromArgb(64, 0, 64);
            dataGridView2.Location = new Point(416, 182);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(911, 530);
            dataGridView2.TabIndex = 124;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 64);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(255, 666);
            button1.Name = "button1";
            button1.Size = new Size(125, 46);
            button1.TabIndex = 126;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 719);
            Controls.Add(dataGridView2);
            Controls.Add(ClientLIstLabel);
            Controls.Add(PharmacyListLabel);
            Controls.Add(ManagerListLable);
            Controls.Add(panel1);
            Controls.Add(ExitLabel);
            Controls.Add(RegistrationManagerAccountLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RegistrationManagerAccountLabel;
        private Label idLabel;
        private Label ExitLabel;
        private TextBox IdTextbox;
        private Label projectnameLabel;
        private Label RecordsLabel;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label PhoneLabel;
        private TextBox SaltTextBox;
        private Label EmailLabel;
        private TextBox CompanyTextBox;
        private Label QuantityLabel;
        private TextBox PriceTextBox;
        private Label PriceLabel;
        private TextBox QuantityTextBox;
        private ComboBox TypeComboBox;
        private Label ManagerListLable;
        private Label PharmacyListLabel;
        private Label ClientLIstLabel;
        private DataGridView dataGridView2;
        private Button PharmacyManagementButton;
        private Button ClientManagementButton;
        private Button ManagerManagementButton;
        private Label UserControlLabel;
        private Button button1;
    }
}