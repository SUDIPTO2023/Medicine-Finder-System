namespace MedicineLocator.View
{
    partial class AdminClientControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminClientControl));
            ResetButton = new Button();
            RemoveButton = new Button();
            BackButton = new Button();
            SearchButton = new Button();
            UpdateButton = new Button();
            dataGridView6 = new DataGridView();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            projectnameLabel = new Label();
            IdTextbox = new TextBox();
            ExitLabel = new Label();
            idLabel = new Label();
            ClientAccountLabel = new Label();
            FemalRadioButton = new RadioButton();
            MaleRadioButton = new RadioButton();
            GenderLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
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
            ResetButton.Location = new Point(1026, 308);
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
            RemoveButton.Location = new Point(649, 308);
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
            BackButton.Location = new Point(1192, 308);
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
            SearchButton.Location = new Point(848, 308);
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
            UpdateButton.Location = new Point(455, 308);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(108, 39);
            UpdateButton.TabIndex = 113;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // dataGridView6
            // 
            dataGridView6.AllowUserToAddRows = false;
            dataGridView6.AllowUserToDeleteRows = false;
            dataGridView6.AllowUserToOrderColumns = true;
            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView6.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView6.BackgroundColor = Color.FromArgb(255, 192, 255);
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Purple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView6.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView6.GridColor = Color.White;
            dataGridView6.Location = new Point(454, 350);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.ReadOnly = true;
            dataGridView6.RowHeadersWidth = 62;
            dataGridView6.Size = new Size(842, 396);
            dataGridView6.TabIndex = 112;
            dataGridView6.CellContentClick += dataGridView6_CellContentClick;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(857, 251);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(208, 31);
            PhoneTextBox.TabIndex = 111;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneLabel.Location = new Point(454, 257);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(142, 21);
            PhoneLabel.TabIndex = 110;
            PhoneLabel.Text = "Phone Number";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(857, 157);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(208, 31);
            NameTextBox.TabIndex = 109;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(455, 167);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(62, 21);
            NameLabel.TabIndex = 108;
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
            panel1.Size = new Size(353, 753);
            panel1.TabIndex = 103;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 64);
            label1.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(31, 470);
            label1.Name = "label1";
            label1.Size = new Size(280, 32);
            label1.TabIndex = 72;
            label1.Text = "Client Management";
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
            IdTextbox.Location = new Point(857, 102);
            IdTextbox.Name = "IdTextbox";
            IdTextbox.Size = new Size(208, 31);
            IdTextbox.TabIndex = 107;
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Cursor = Cursors.Hand;
            ExitLabel.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitLabel.Location = new Point(1325, 0);
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
            idLabel.Location = new Point(455, 112);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(75, 21);
            idLabel.TabIndex = 106;
            idLabel.Text = "User Id";
            // 
            // ClientAccountLabel
            // 
            ClientAccountLabel.AutoSize = true;
            ClientAccountLabel.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClientAccountLabel.Location = new Point(703, 9);
            ClientAccountLabel.Name = "ClientAccountLabel";
            ClientAccountLabel.Size = new Size(294, 37);
            ClientAccountLabel.TabIndex = 105;
            ClientAccountLabel.Text = "Client Information";
            // 
            // FemalRadioButton
            // 
            FemalRadioButton.AutoSize = true;
            FemalRadioButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FemalRadioButton.Location = new Point(965, 215);
            FemalRadioButton.Name = "FemalRadioButton";
            FemalRadioButton.Size = new Size(100, 25);
            FemalRadioButton.TabIndex = 120;
            FemalRadioButton.TabStop = true;
            FemalRadioButton.Text = "Female";
            FemalRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaleRadioButton.Location = new Point(857, 215);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(77, 25);
            MaleRadioButton.TabIndex = 119;
            MaleRadioButton.TabStop = true;
            MaleRadioButton.Text = "Male";
            MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenderLabel.Location = new Point(454, 215);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(76, 21);
            GenderLabel.TabIndex = 118;
            GenderLabel.Text = "Gender";
            // 
            // AdminClientControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 753);
            Controls.Add(FemalRadioButton);
            Controls.Add(MaleRadioButton);
            Controls.Add(GenderLabel);
            Controls.Add(ResetButton);
            Controls.Add(RemoveButton);
            Controls.Add(BackButton);
            Controls.Add(SearchButton);
            Controls.Add(UpdateButton);
            Controls.Add(dataGridView6);
            Controls.Add(PhoneTextBox);
            Controls.Add(PhoneLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(panel1);
            Controls.Add(IdTextbox);
            Controls.Add(ExitLabel);
            Controls.Add(idLabel);
            Controls.Add(ClientAccountLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminClientControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminClientControl";
            Load += AdminClientControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
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
        private DataGridView dataGridView6;
        private TextBox PhoneTextBox;
        private Label PhoneLabel;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label projectnameLabel;
        private TextBox IdTextbox;
        private Label ExitLabel;
        private Label idLabel;
        private Label ClientAccountLabel;
        private RadioButton FemalRadioButton;
        private RadioButton MaleRadioButton;
        private Label GenderLabel;
    }
}