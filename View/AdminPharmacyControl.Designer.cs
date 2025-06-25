namespace MedicineLocator.View
{
    partial class AdminPharmacyControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPharmacyControl));
            ResetButton = new Button();
            RemoveButton = new Button();
            BackButton = new Button();
            SearchButton = new Button();
            UpdateButton = new Button();
            dataGridView4 = new DataGridView();
            LocationTextBox = new TextBox();
            LocationLabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            panel1 = new Panel();
            PharmacyManagementLabel = new Label();
            pictureBox1 = new PictureBox();
            projectnameLabel = new Label();
            IdTextbox = new TextBox();
            ExitLabel = new Label();
            idLabel = new Label();
            PharmacyLabel = new Label();
            LisenceTextBox = new TextBox();
            LisenceLabel = new Label();
            ManagerIDLable = new Label();
            ManagerTextIBoxId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.FromArgb(64, 0, 64);
            ResetButton.Cursor = Cursors.Hand;
            ResetButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetButton.ForeColor = Color.White;
            ResetButton.Location = new Point(970, 329);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(97, 39);
            ResetButton.TabIndex = 117;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = Color.FromArgb(64, 0, 64);
            RemoveButton.Cursor = Cursors.Hand;
            RemoveButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveButton.ForeColor = Color.White;
            RemoveButton.Location = new Point(649, 329);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(114, 39);
            RemoveButton.TabIndex = 116;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(64, 0, 64);
            BackButton.Cursor = Cursors.Hand;
            BackButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(1094, 329);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(95, 39);
            BackButton.TabIndex = 115;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.FromArgb(64, 0, 64);
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(820, 329);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(108, 39);
            SearchButton.TabIndex = 114;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.FromArgb(64, 0, 64);
            UpdateButton.Cursor = Cursors.Hand;
            UpdateButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(471, 329);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(108, 39);
            UpdateButton.TabIndex = 113;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AllowUserToOrderColumns = true;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView4.BackgroundColor = Color.FromArgb(255, 192, 255);
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Purple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView4.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView4.GridColor = Color.White;
            dataGridView4.Location = new Point(471, 374);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.Size = new Size(718, 368);
            dataGridView4.TabIndex = 112;
            dataGridView4.CellContentClick += dataGridView4_CellContentClick;
            // 
            // LocationTextBox
            // 
            LocationTextBox.Location = new Point(914, 160);
            LocationTextBox.Name = "LocationTextBox";
            LocationTextBox.Size = new Size(208, 31);
            LocationTextBox.TabIndex = 111;
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LocationLabel.Location = new Point(512, 166);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(87, 21);
            LocationLabel.TabIndex = 110;
            LocationLabel.Text = "Location";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(914, 115);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(208, 31);
            NameTextBox.TabIndex = 109;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(512, 125);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(62, 21);
            NameLabel.TabIndex = 108;
            NameLabel.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(PharmacyManagementLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(projectnameLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 754);
            panel1.TabIndex = 103;
            // 
            // PharmacyManagementLabel
            // 
            PharmacyManagementLabel.AutoSize = true;
            PharmacyManagementLabel.BackColor = Color.FromArgb(64, 0, 64);
            PharmacyManagementLabel.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PharmacyManagementLabel.ForeColor = Color.Transparent;
            PharmacyManagementLabel.Location = new Point(3, 465);
            PharmacyManagementLabel.Name = "PharmacyManagementLabel";
            PharmacyManagementLabel.Size = new Size(338, 32);
            PharmacyManagementLabel.TabIndex = 72;
            PharmacyManagementLabel.Text = "Pharmacy Management";
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
            // projectnameLabel
            // 
            projectnameLabel.AutoSize = true;
            projectnameLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectnameLabel.ForeColor = Color.Transparent;
            projectnameLabel.Location = new Point(31, 281);
            projectnameLabel.Name = "projectnameLabel";
            projectnameLabel.Size = new Size(289, 28);
            projectnameLabel.TabIndex = 9;
            projectnameLabel.Text = "Medicine Finder System";
            // 
            // IdTextbox
            // 
            IdTextbox.Location = new Point(914, 66);
            IdTextbox.Name = "IdTextbox";
            IdTextbox.Size = new Size(208, 31);
            IdTextbox.TabIndex = 107;
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Cursor = Cursors.Hand;
            ExitLabel.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitLabel.Location = new Point(1225, 9);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(24, 24);
            ExitLabel.TabIndex = 104;
            ExitLabel.Text = "X";
            ExitLabel.Click += ExitLabel_Click;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idLabel.Location = new Point(512, 76);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 21);
            idLabel.TabIndex = 106;
            idLabel.Text = "Id";
            // 
            // PharmacyLabel
            // 
            PharmacyLabel.AutoSize = true;
            PharmacyLabel.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PharmacyLabel.Location = new Point(649, 9);
            PharmacyLabel.Name = "PharmacyLabel";
            PharmacyLabel.Size = new Size(359, 37);
            PharmacyLabel.TabIndex = 105;
            PharmacyLabel.Text = "Pharmacy Information";
            // 
            // LisenceTextBox
            // 
            LisenceTextBox.Location = new Point(914, 209);
            LisenceTextBox.Name = "LisenceTextBox";
            LisenceTextBox.Size = new Size(208, 31);
            LisenceTextBox.TabIndex = 119;
            // 
            // LisenceLabel
            // 
            LisenceLabel.AutoSize = true;
            LisenceLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LisenceLabel.Location = new Point(512, 219);
            LisenceLabel.Name = "LisenceLabel";
            LisenceLabel.Size = new Size(156, 21);
            LisenceLabel.TabIndex = 120;
            LisenceLabel.Text = "Lisence Number";
            // 
            // ManagerIDLable
            // 
            ManagerIDLable.AutoSize = true;
            ManagerIDLable.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ManagerIDLable.Location = new Point(512, 272);
            ManagerIDLable.Name = "ManagerIDLable";
            ManagerIDLable.Size = new Size(110, 21);
            ManagerIDLable.TabIndex = 121;
            ManagerIDLable.Text = "Manager Id";
            // 
            // ManagerTextIBoxId
            // 
            ManagerTextIBoxId.Location = new Point(914, 262);
            ManagerTextIBoxId.Name = "ManagerTextIBoxId";
            ManagerTextIBoxId.Size = new Size(208, 31);
            ManagerTextIBoxId.TabIndex = 122;
            // 
            // AdminPharmacyControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 754);
            Controls.Add(ManagerTextIBoxId);
            Controls.Add(ManagerIDLable);
            Controls.Add(LisenceLabel);
            Controls.Add(LisenceTextBox);
            Controls.Add(ResetButton);
            Controls.Add(RemoveButton);
            Controls.Add(BackButton);
            Controls.Add(SearchButton);
            Controls.Add(UpdateButton);
            Controls.Add(dataGridView4);
            Controls.Add(LocationTextBox);
            Controls.Add(LocationLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(panel1);
            Controls.Add(IdTextbox);
            Controls.Add(ExitLabel);
            Controls.Add(idLabel);
            Controls.Add(PharmacyLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPharmacyControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPharmacyControl";
            Load += AdminPharmacyControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ResetButton;
        private Button RemoveButton;
        private Button BackButton;
        private Button SearchButton;
        private Button UpdateButton;
        private DataGridView dataGridView4;
        private TextBox LocationTextBox;
        private Label LocationLabel;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Panel panel1;
        private Label PharmacyManagementLabel;
        private PictureBox pictureBox1;
        private Label projectnameLabel;
        private TextBox IdTextbox;
        private Label ExitLabel;
        private Label idLabel;
        private Label PharmacyLabel;
        private TextBox LisenceTextBox;
        private Label LisenceLabel;
        private Label ManagerIDLable;
        private TextBox ManagerTextIBoxId;
    }
}