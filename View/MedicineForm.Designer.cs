namespace MedicineLocator.View
{
    partial class MedicineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            RecordsLabel = new Label();
            projectnameLabel = new Label();
            CompanyTextBox = new TextBox();
            EmailLabel = new Label();
            SaltTextBox = new TextBox();
            PhoneLabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            IdTextbox = new TextBox();
            ExitLabel = new Label();
            idLabel = new Label();
            RegistrationManagerAccountLabel = new Label();
            QuantityLabel = new Label();
            PriceTextBox = new TextBox();
            PriceLabel = new Label();
            QuantityTextBox = new TextBox();
            label1 = new Label();
            TypeComboBox = new ComboBox();
            dataGridView1 = new DataGridView();
            AddButton = new Button();
            UpdateButton = new Button();
            SearchButton = new Button();
            BackButton = new Button();
            RemoveButton = new Button();
            ResetButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // RecordsLabel
            // 
            RecordsLabel.AutoSize = true;
            RecordsLabel.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecordsLabel.ForeColor = Color.WhiteSmoke;
            RecordsLabel.Location = new Point(33, 427);
            RecordsLabel.Name = "RecordsLabel";
            RecordsLabel.Size = new Size(279, 32);
            RecordsLabel.TabIndex = 10;
            RecordsLabel.Text = "Medicnine Records";
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
            // CompanyTextBox
            // 
            CompanyTextBox.Location = new Point(630, 244);
            CompanyTextBox.Name = "CompanyTextBox";
            CompanyTextBox.Size = new Size(208, 31);
            CompanyTextBox.TabIndex = 72;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailLabel.Location = new Point(429, 244);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(93, 21);
            EmailLabel.TabIndex = 71;
            EmailLabel.Text = "Company";
            // 
            // SaltTextBox
            // 
            SaltTextBox.Location = new Point(630, 190);
            SaltTextBox.Name = "SaltTextBox";
            SaltTextBox.Size = new Size(208, 31);
            SaltTextBox.TabIndex = 70;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneLabel.Location = new Point(426, 196);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(44, 21);
            PhoneLabel.TabIndex = 69;
            PhoneLabel.Text = "Salt";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(630, 138);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(208, 31);
            NameTextBox.TabIndex = 68;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(426, 144);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(62, 21);
            NameLabel.TabIndex = 67;
            NameLabel.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(RecordsLabel);
            panel1.Controls.Add(projectnameLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 750);
            panel1.TabIndex = 58;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 157);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // IdTextbox
            // 
            IdTextbox.Location = new Point(630, 83);
            IdTextbox.Name = "IdTextbox";
            IdTextbox.Size = new Size(208, 31);
            IdTextbox.TabIndex = 63;
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Cursor = Cursors.Hand;
            ExitLabel.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitLabel.Location = new Point(1301, 0);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(24, 24);
            ExitLabel.TabIndex = 59;
            ExitLabel.Text = "X";
            ExitLabel.Click += ExitLabel_Click;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idLabel.Location = new Point(426, 83);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 21);
            idLabel.TabIndex = 61;
            idLabel.Text = "Id";
            // 
            // RegistrationManagerAccountLabel
            // 
            RegistrationManagerAccountLabel.AutoSize = true;
            RegistrationManagerAccountLabel.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegistrationManagerAccountLabel.Location = new Point(678, 9);
            RegistrationManagerAccountLabel.Name = "RegistrationManagerAccountLabel";
            RegistrationManagerAccountLabel.Size = new Size(344, 37);
            RegistrationManagerAccountLabel.TabIndex = 60;
            RegistrationManagerAccountLabel.Text = "Medicine Information";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuantityLabel.Location = new Point(911, 144);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(84, 21);
            QuantityLabel.TabIndex = 84;
            QuantityLabel.Text = "Quantity";
            // 
            // PriceTextBox
            // 
            PriceTextBox.BackColor = SystemColors.HighlightText;
            PriceTextBox.Location = new Point(1039, 83);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(208, 31);
            PriceTextBox.TabIndex = 85;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceLabel.Location = new Point(911, 93);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(57, 21);
            PriceLabel.TabIndex = 86;
            PriceLabel.Text = "Price";
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.BackColor = SystemColors.HighlightText;
            QuantityTextBox.Location = new Point(1039, 138);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(208, 31);
            QuantityTextBox.TabIndex = 87;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(911, 200);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 88;
            label1.Text = "Type";
            // 
            // TypeComboBox
            // 
            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Tablet", "Capsule", "Syrup" });
            TypeComboBox.Location = new Point(1039, 200);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(208, 33);
            TypeComboBox.TabIndex = 90;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 192, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Purple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(429, 386);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(818, 355);
            dataGridView1.TabIndex = 91;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(64, 0, 64);
            AddButton.Cursor = Cursors.Hand;
            AddButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(426, 341);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(93, 39);
            AddButton.TabIndex = 92;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.FromArgb(64, 0, 64);
            UpdateButton.Cursor = Cursors.Hand;
            UpdateButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(577, 341);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(108, 39);
            UpdateButton.TabIndex = 93;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.FromArgb(64, 0, 64);
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(887, 341);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(108, 39);
            SearchButton.TabIndex = 94;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(64, 0, 64);
            BackButton.Cursor = Cursors.Hand;
            BackButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(1152, 341);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(95, 39);
            BackButton.TabIndex = 95;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = Color.FromArgb(64, 0, 64);
            RemoveButton.Cursor = Cursors.Hand;
            RemoveButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveButton.ForeColor = Color.White;
            RemoveButton.Location = new Point(724, 341);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(114, 39);
            RemoveButton.TabIndex = 96;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.FromArgb(64, 0, 64);
            ResetButton.Cursor = Cursors.Hand;
            ResetButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetButton.ForeColor = Color.White;
            ResetButton.Location = new Point(1024, 341);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(97, 39);
            ResetButton.TabIndex = 97;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // MedicineForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 750);
            Controls.Add(ResetButton);
            Controls.Add(RemoveButton);
            Controls.Add(BackButton);
            Controls.Add(SearchButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridView1);
            Controls.Add(TypeComboBox);
            Controls.Add(label1);
            Controls.Add(QuantityTextBox);
            Controls.Add(PriceLabel);
            Controls.Add(PriceTextBox);
            Controls.Add(QuantityLabel);
            Controls.Add(CompanyTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(SaltTextBox);
            Controls.Add(PhoneLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(panel1);
            Controls.Add(IdTextbox);
            Controls.Add(ExitLabel);
            Controls.Add(idLabel);
            Controls.Add(RegistrationManagerAccountLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MedicineForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MedicineForm";
            Load += MedicineForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label RecordsLabel;
        private Label projectnameLabel;
        private TextBox CompanyTextBox;
        private Label EmailLabel;
        private TextBox SaltTextBox;
        private Label PhoneLabel;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Panel panel1;
        private TextBox IdTextbox;
        private Label ExitLabel;
        private Label idLabel;
        private Label RegistrationManagerAccountLabel;
        private Label QuantityLabel;
        private TextBox PriceTextBox;
        private Label PriceLabel;
        private TextBox QuantityTextBox;
        private Label label1;
        private ComboBox TypeComboBox;
        private DataGridView dataGridView1;
        private Button AddButton;
        private Button UpdateButton;
        private Button SearchButton;
        private Button BackButton;
        private Button RemoveButton;
        private Button ResetButton;
        private PictureBox pictureBox1;
    }
}