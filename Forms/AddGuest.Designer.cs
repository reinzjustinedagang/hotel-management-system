namespace HotelManagementSystem.Forms
{
    partial class AddGuest
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
            lbTitle = new Label();
            label2 = new Label();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            label3 = new Label();
            cbGender = new ComboBox();
            label4 = new Label();
            tbPhone = new TextBox();
            label5 = new Label();
            tbEmail = new TextBox();
            label6 = new Label();
            birthDate = new DateTimePicker();
            label7 = new Label();
            tbAddress = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            cbValidID = new ComboBox();
            btnSave = new Button();
            button2 = new Button();
            cbNationality = new ComboBox();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(12, 9);
            lbTitle.Margin = new Padding(3, 0, 3, 20);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(541, 52);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Add New Guest";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 81);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // tbFirstName
            // 
            tbFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFirstName.Location = new Point(40, 105);
            tbFirstName.MaxLength = 50;
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(241, 29);
            tbFirstName.TabIndex = 2;
            // 
            // tbLastName
            // 
            tbLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLastName.Location = new Point(287, 105);
            tbLastName.MaxLength = 50;
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(241, 29);
            tbLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(287, 81);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // cbGender
            // 
            cbGender.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbGender.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(40, 161);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(241, 29);
            cbGender.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 137);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhone.Location = new Point(40, 217);
            tbPhone.MaxLength = 11;
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(241, 29);
            tbPhone.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 193);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 9;
            label5.Text = "Phone";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(287, 217);
            tbEmail.MaxLength = 50;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(241, 29);
            tbEmail.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(287, 193);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 7;
            label6.Text = "Email";
            // 
            // birthDate
            // 
            birthDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            birthDate.Format = DateTimePickerFormat.Short;
            birthDate.Location = new Point(287, 161);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(241, 29);
            birthDate.TabIndex = 11;
            birthDate.Value = new DateTime(2026, 8, 4, 21, 36, 54, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(287, 137);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 12;
            label7.Text = "Birthdate";
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAddress.Location = new Point(40, 273);
            tbAddress.MaxLength = 500;
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(488, 79);
            tbAddress.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(40, 249);
            label8.Name = "label8";
            label8.Size = new Size(66, 21);
            label8.TabIndex = 13;
            label8.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(40, 355);
            label9.Name = "label9";
            label9.Size = new Size(86, 21);
            label9.TabIndex = 15;
            label9.Text = "Nationality";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(287, 355);
            label10.Name = "label10";
            label10.Size = new Size(63, 21);
            label10.TabIndex = 18;
            label10.Text = "Valid ID";
            // 
            // cbValidID
            // 
            cbValidID.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbValidID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbValidID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbValidID.FormattingEnabled = true;
            cbValidID.Location = new Point(287, 379);
            cbValidID.Name = "cbValidID";
            cbValidID.Size = new Size(241, 29);
            cbValidID.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(83, 67, 199);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(40, 431);
            btnSave.Margin = new Padding(3, 20, 3, 20);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(241, 35);
            btnSave.TabIndex = 19;
            btnSave.Text = "Add New Guest";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(287, 431);
            button2.Margin = new Padding(3, 20, 3, 20);
            button2.Name = "button2";
            button2.Size = new Size(241, 35);
            button2.TabIndex = 20;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cbNationality
            // 
            cbNationality.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbNationality.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNationality.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbNationality.FormattingEnabled = true;
            cbNationality.Location = new Point(40, 379);
            cbNationality.Name = "cbNationality";
            cbNationality.Size = new Size(241, 29);
            cbNationality.TabIndex = 21;
            // 
            // AddGuest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 497);
            Controls.Add(cbNationality);
            Controls.Add(button2);
            Controls.Add(btnSave);
            Controls.Add(label10);
            Controls.Add(cbValidID);
            Controls.Add(label9);
            Controls.Add(tbAddress);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(birthDate);
            Controls.Add(tbPhone);
            Controls.Add(label5);
            Controls.Add(tbEmail);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(cbGender);
            Controls.Add(tbLastName);
            Controls.Add(label3);
            Controls.Add(tbFirstName);
            Controls.Add(label2);
            Controls.Add(lbTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddGuest";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddGuest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label label2;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private Label label3;
        private ComboBox cbGender;
        private Label label4;
        private TextBox tbPhone;
        private Label label5;
        private TextBox tbEmail;
        private Label label6;
        private DateTimePicker birthDate;
        private Label label7;
        private TextBox tbAddress;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cbValidID;
        private Button btnSave;
        private Button button2;
        private ComboBox cbNationality;
    }
}