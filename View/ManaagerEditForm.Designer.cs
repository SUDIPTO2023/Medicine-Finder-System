namespace MedicineLocator.View
{
    partial class ManaagerEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManaagerEditForm));
            EditButton = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            BackButton = new Button();
            projectnameLabel = new Label();
            IdTextbox = new TextBox();
            ExitLabel = new Label();
            idLabel = new Label();
            InformationLabel = new Label();
            NameTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            NameLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.FromArgb(64, 0, 64);
            EditButton.Cursor = Cursors.Hand;
            EditButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(448, 360);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(161, 39);
            EditButton.TabIndex = 58;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(projectnameLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 681);
            panel1.TabIndex = 46;
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
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(64, 0, 64);
            BackButton.Cursor = Cursors.Hand;
            BackButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(23, 581);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(289, 39);
            BackButton.TabIndex = 9;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
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
            // IdTextbox
            // 
            IdTextbox.Location = new Point(652, 124);
            IdTextbox.Name = "IdTextbox";
            IdTextbox.Size = new Size(208, 31);
            IdTextbox.TabIndex = 50;
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Cursor = Cursors.Hand;
            ExitLabel.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitLabel.Location = new Point(1047, 9);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(24, 24);
            ExitLabel.TabIndex = 47;
            ExitLabel.Text = "X";
            ExitLabel.Click += ExitLabel_Click;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idLabel.Location = new Point(448, 124);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 21);
            idLabel.TabIndex = 49;
            idLabel.Text = "Id";
            // 
            // InformationLabel
            // 
            InformationLabel.AutoSize = true;
            InformationLabel.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InformationLabel.Location = new Point(600, 20);
            InformationLabel.Name = "InformationLabel";
            InformationLabel.Size = new Size(275, 37);
            InformationLabel.TabIndex = 48;
            InformationLabel.Text = "Your Information";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(652, 182);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(208, 31);
            NameTextBox.TabIndex = 52;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(652, 250);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(208, 31);
            PhoneTextBox.TabIndex = 57;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneLabel.Location = new Point(448, 260);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(142, 21);
            PhoneLabel.TabIndex = 56;
            PhoneLabel.Text = "Phone Number";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(448, 188);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(62, 21);
            NameLabel.TabIndex = 51;
            NameLabel.Text = "Name";
            // 
            // ManaagerEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 681);
            Controls.Add(EditButton);
            Controls.Add(panel1);
            Controls.Add(IdTextbox);
            Controls.Add(ExitLabel);
            Controls.Add(idLabel);
            Controls.Add(InformationLabel);
            Controls.Add(NameTextBox);
            Controls.Add(PhoneTextBox);
            Controls.Add(PhoneLabel);
            Controls.Add(NameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManaagerEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManaagerEditForm";
            Load += ManaagerEditForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditButton;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button BackButton;
        private Label projectnameLabel;
        private TextBox IdTextbox;
        private Label ExitLabel;
        private Label idLabel;
        private Label InformationLabel;
        private TextBox NameTextBox;
        private TextBox PhoneTextBox;
        private Label PhoneLabel;
        private Label NameLabel;
    }
}