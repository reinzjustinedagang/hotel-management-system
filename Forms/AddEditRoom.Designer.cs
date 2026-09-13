namespace HotelManagementSystem.Forms
{
    partial class AddEditRoom
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
            button2 = new Button();
            label1 = new Label();
            tbDescription = new TextBox();
            numRoomNum = new NumericUpDown();
            numFloor = new NumericUpDown();
            label2 = new Label();
            numCapacity = new NumericUpDown();
            label3 = new Label();
            numPrice = new NumericUpDown();
            label4 = new Label();
            cbRoomType = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cbStatus = new ComboBox();
            label8 = new Label();
            btnAddEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)numRoomNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(12, 9);
            lbTitle.Margin = new Padding(3, 0, 3, 20);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(541, 52);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Add New Room";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(289, 390);
            button2.Margin = new Padding(3, 20, 3, 20);
            button2.Name = "button2";
            button2.Size = new Size(264, 35);
            button2.TabIndex = 21;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 22;
            label1.Text = "Room Number";
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbDescription.Font = new Font("Segoe UI", 12F);
            tbDescription.Location = new Point(12, 273);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(541, 94);
            tbDescription.TabIndex = 23;
            // 
            // numRoomNum
            // 
            numRoomNum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numRoomNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numRoomNum.Location = new Point(12, 105);
            numRoomNum.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numRoomNum.Name = "numRoomNum";
            numRoomNum.Size = new Size(264, 29);
            numRoomNum.TabIndex = 24;
            // 
            // numFloor
            // 
            numFloor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numFloor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numFloor.Location = new Point(12, 161);
            numFloor.Name = "numFloor";
            numFloor.Size = new Size(264, 29);
            numFloor.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 137);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 25;
            label2.Text = "Floor";
            // 
            // numCapacity
            // 
            numCapacity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numCapacity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numCapacity.Location = new Point(289, 161);
            numCapacity.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.ReadOnly = true;
            numCapacity.Size = new Size(264, 29);
            numCapacity.TabIndex = 28;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(289, 137);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 27;
            label3.Text = "Capacity";
            // 
            // numPrice
            // 
            numPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numPrice.Location = new Point(12, 217);
            numPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.ReadOnly = true;
            numPrice.Size = new Size(264, 29);
            numPrice.TabIndex = 30;
            numPrice.ThousandsSeparator = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 193);
            label4.Name = "label4";
            label4.Size = new Size(114, 21);
            label4.TabIndex = 29;
            label4.Text = "Price per Night";
            // 
            // cbRoomType
            // 
            cbRoomType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Location = new Point(289, 104);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(264, 29);
            cbRoomType.TabIndex = 33;
            cbRoomType.SelectedIndexChanged += cbRoomType_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(289, 81);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 34;
            label6.Text = "Room Type";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(289, 193);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 36;
            label7.Text = "Status";
            // 
            // cbStatus
            // 
            cbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(289, 216);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(264, 29);
            cbStatus.TabIndex = 35;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(12, 249);
            label8.Name = "label8";
            label8.Size = new Size(89, 21);
            label8.TabIndex = 37;
            label8.Text = "Description";
            // 
            // btnAddEdit
            // 
            btnAddEdit.Anchor = AnchorStyles.Right;
            btnAddEdit.BackColor = Color.FromArgb(83, 67, 199);
            btnAddEdit.FlatAppearance.BorderSize = 0;
            btnAddEdit.FlatStyle = FlatStyle.Flat;
            btnAddEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEdit.ForeColor = Color.White;
            btnAddEdit.Location = new Point(12, 390);
            btnAddEdit.Margin = new Padding(3, 20, 3, 20);
            btnAddEdit.Name = "btnAddEdit";
            btnAddEdit.Size = new Size(264, 35);
            btnAddEdit.TabIndex = 38;
            btnAddEdit.Text = "Add New Room";
            btnAddEdit.UseVisualStyleBackColor = false;
            btnAddEdit.Click += btnAddEdit_Click;
            // 
            // AddEditRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 448);
            Controls.Add(btnAddEdit);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cbStatus);
            Controls.Add(label6);
            Controls.Add(cbRoomType);
            Controls.Add(numPrice);
            Controls.Add(label4);
            Controls.Add(numCapacity);
            Controls.Add(label3);
            Controls.Add(numFloor);
            Controls.Add(label2);
            Controls.Add(numRoomNum);
            Controls.Add(tbDescription);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(lbTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEditRoom";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddEditRoom";
            ((System.ComponentModel.ISupportInitialize)numRoomNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Button button2;
        private Label label1;
        private TextBox tbDescription;
        private NumericUpDown numRoomNum;
        private NumericUpDown numFloor;
        private Label label2;
        private NumericUpDown numCapacity;
        private Label label3;
        private NumericUpDown numPrice;
        private Label label4;
        private ComboBox cbRoomType;
        private Label label6;
        private Label label7;
        private ComboBox cbStatus;
        private Label label8;
        private Button btnAddEdit;
    }
}