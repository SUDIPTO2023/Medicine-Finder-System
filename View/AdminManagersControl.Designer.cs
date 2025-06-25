namespace MedicineLocator.View
{
    partial class AdminManagersControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManagersControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            projectnameLabel = new Label();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            IdTextbox = new TextBox();
            ExitLabel = new Label();
            idLabel = new Label();
            RegistrationManagerAccountLabel = new Label();
            dataGridView3 = new DataGridView();
            ResetButton = new Button();
            RemoveButton = new Button();
            BackButton = new Button();
            SearchButton = new Button();
            UpdateButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
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
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(820, 205);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(208, 31);
            PhoneTextBox.TabIndex = 70;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneLabel.Location = new Point(418, 215);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(142, 21);
            PhoneLabel.TabIndex = 69;
            PhoneLabel.Text = "Phone Number";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(820, 157);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(208, 31);
            NameTextBox.TabIndex = 68;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(418, 167);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(62, 21);
            NameLabel.TabIndex = 67;
            NameLabel.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(projectnameLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 751);
            panel1.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 64);
            label1.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(10, 465);
            label1.Name = "label1";
            label1.Size = new Size(320, 32);
            label1.TabIndex = 72;
            label1.Text = "Manager Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(83, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 157);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // IdTextbox
            // 
            IdTextbox.Location = new Point(820, 102);
            IdTextbox.Name = "IdTextbox";
            IdTextbox.Size = new Size(208, 31);
            IdTextbox.TabIndex = 63;
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Cursor = Cursors.Hand;
            ExitLabel.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitLabel.Location = new Point(1280, 9);
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
            idLabel.Location = new Point(418, 112);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 21);
            idLabel.TabIndex = 61;
            idLabel.Text = "Id";
            // 
            // RegistrationManagerAccountLabel
            // 
            RegistrationManagerAccountLabel.AutoSize = true;
            RegistrationManagerAccountLabel.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegistrationManagerAccountLabel.Location = new Point(667, 9);
            RegistrationManagerAccountLabel.Name = "RegistrationManagerAccountLabel";
            RegistrationManagerAccountLabel.Size = new Size(340, 37);
            RegistrationManagerAccountLabel.TabIndex = 60;
            RegistrationManagerAccountLabel.Text = "Manager Information";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToOrderColumns = true;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView3.BackgroundColor = Color.FromArgb(255, 192, 255);
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Purple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView3.GridColor = Color.White;
            dataGridView3.Location = new Point(408, 330);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(842, 396);
            dataGridView3.TabIndex = 71;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.FromArgb(64, 0, 64);
            ResetButton.Cursor = Cursors.Hand;
            ResetButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetButton.ForeColor = Color.White;
            ResetButton.Location = new Point(989, 285);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(97, 39);
            ResetButton.TabIndex = 102;
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
            RemoveButton.Location = new Point(612, 285);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(114, 39);
            RemoveButton.TabIndex = 101;
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
            BackButton.Location = new Point(1155, 285);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(95, 39);
            BackButton.TabIndex = 100;
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
            SearchButton.Location = new Point(811, 285);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(108, 39);
            SearchButton.TabIndex = 99;
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
            UpdateButton.Location = new Point(418, 285);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(108, 39);
            UpdateButton.TabIndex = 98;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AdminManagersControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 751);
            Controls.Add(ResetButton);
            Controls.Add(RemoveButton);
            Controls.Add(BackButton);
            Controls.Add(SearchButton);
            Controls.Add(UpdateButton);
            Controls.Add(dataGridView3);
            Controls.Add(PhoneTextBox);
            Controls.Add(PhoneLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(panel1);
            Controls.Add(IdTextbox);
            Controls.Add(ExitLabel);
            Controls.Add(idLabel);
            Controls.Add(RegistrationManagerAccountLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminManagersControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManagersControl";
            Load += AdminManagersControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label projectnameLabel;
        private TextBox PhoneTextBox;
        private Label PhoneLabel;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox IdTextbox;
        private Label ExitLabel;
        private Label idLabel;
        private Label RegistrationManagerAccountLabel;
        private DataGridView dataGridView3;
        private Label label1;
        private Button ResetButton;
        private Button RemoveButton;
        private Button BackButton;
        private Button SearchButton;
        private Button UpdateButton;
    }
}