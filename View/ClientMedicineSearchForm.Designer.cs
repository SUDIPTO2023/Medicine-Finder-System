namespace MedicineLocator.View
{
    partial class ClientMedicineSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMedicineSearchForm));
            BackButton = new Button();
            SearchButton = new Button();
            dataGridView5 = new DataGridView();
            LocationLabel = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            projectnameLabel = new Label();
            NameTextbox = new TextBox();
            ExitLabel = new Label();
            MedicineLabel = new Label();
            RegistrationManagerAccountLabel = new Label();
            LocationComboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(64, 0, 64);
            BackButton.Cursor = Cursors.Hand;
            BackButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(1492, 285);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(106, 39);
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
            SearchButton.Location = new Point(384, 285);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(108, 39);
            SearchButton.TabIndex = 114;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // dataGridView5
            // 
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.AllowUserToDeleteRows = false;
            dataGridView5.AllowUserToOrderColumns = true;
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView5.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView5.BackgroundColor = Color.FromArgb(255, 192, 255);
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Purple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView5.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView5.GridColor = Color.White;
            dataGridView5.Location = new Point(384, 330);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.ReadOnly = true;
            dataGridView5.RowHeadersWidth = 62;
            dataGridView5.Size = new Size(1214, 420);
            dataGridView5.TabIndex = 112;
            dataGridView5.CellContentClick += dataGridView5_CellContentClick;
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LocationLabel.Location = new Point(664, 189);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(87, 21);
            LocationLabel.TabIndex = 108;
            LocationLabel.Text = "Location";
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
            panel1.Size = new Size(353, 762);
            panel1.TabIndex = 103;
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
            // NameTextbox
            // 
            NameTextbox.Location = new Point(1066, 124);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(208, 31);
            NameTextbox.TabIndex = 107;
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Cursor = Cursors.Hand;
            ExitLabel.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitLabel.Location = new Point(1597, 0);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(24, 24);
            ExitLabel.TabIndex = 104;
            ExitLabel.Text = "X";
            ExitLabel.Click += ExitLabel_Click;
            // 
            // MedicineLabel
            // 
            MedicineLabel.AutoSize = true;
            MedicineLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MedicineLabel.Location = new Point(664, 134);
            MedicineLabel.Name = "MedicineLabel";
            MedicineLabel.Size = new Size(147, 21);
            MedicineLabel.TabIndex = 106;
            MedicineLabel.Text = "Medicine Name";
            // 
            // RegistrationManagerAccountLabel
            // 
            RegistrationManagerAccountLabel.AutoSize = true;
            RegistrationManagerAccountLabel.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegistrationManagerAccountLabel.Location = new Point(834, 9);
            RegistrationManagerAccountLabel.Name = "RegistrationManagerAccountLabel";
            RegistrationManagerAccountLabel.Size = new Size(277, 37);
            RegistrationManagerAccountLabel.TabIndex = 105;
            RegistrationManagerAccountLabel.Text = "Search Medicine";
            // 
            // LocationComboBox1
            // 
            LocationComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            LocationComboBox1.FormattingEnabled = true;
            LocationComboBox1.Items.AddRange(new object[] { "Dhaka", "Mirpur", "Dhanmondi", "Bashundhara", "Uttara", "Gulshan", "Banani", "Kuril", "Khilkhet", "Nikunja" });
            LocationComboBox1.Location = new Point(1066, 189);
            LocationComboBox1.Name = "LocationComboBox1";
            LocationComboBox1.Size = new Size(208, 33);
            LocationComboBox1.TabIndex = 118;
            // 
            // ClientMedicineSearchForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1623, 762);
            Controls.Add(LocationComboBox1);
            Controls.Add(BackButton);
            Controls.Add(SearchButton);
            Controls.Add(dataGridView5);
            Controls.Add(LocationLabel);
            Controls.Add(panel1);
            Controls.Add(NameTextbox);
            Controls.Add(ExitLabel);
            Controls.Add(MedicineLabel);
            Controls.Add(RegistrationManagerAccountLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientMedicineSearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientMedicineSearchForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BackButton;
        private Button SearchButton;
        private DataGridView dataGridView5;
        private Label LocationLabel;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label projectnameLabel;
        private TextBox NameTextbox;
        private Label ExitLabel;
        private Label MedicineLabel;
        private Label RegistrationManagerAccountLabel;
        private ComboBox LocationComboBox1;
    }
}