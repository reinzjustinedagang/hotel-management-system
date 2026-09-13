namespace HotelManagementSystem.Forms
{
    partial class AddEditReservation
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label3 = new Label();
            cbStatus = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cbPrimaryGuest = new ComboBox();
            label4 = new Label();
            btnAddGuest = new Button();
            label5 = new Label();
            label6 = new Label();
            cbRoomType = new ComboBox();
            cbRoom = new ComboBox();
            label7 = new Label();
            checkinDate = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            checkoutDate = new DateTimePicker();
            label10 = new Label();
            label15 = new Label();
            label16 = new Label();
            cbAdditionalGuest = new ComboBox();
            label17 = new Label();
            btnAddNewGuestForAddtional = new Button();
            additionalGuestTable = new DataGridView();
            btnAddToList = new Button();
            label11 = new Label();
            txtPrice = new Label();
            txtCapacity = new Label();
            txtNights = new Label();
            ((System.ComponentModel.ISupportInitialize)additionalGuestTable).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 95);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 1;
            label3.Text = "Status:";
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(79, 87);
            cbStatus.Margin = new Padding(3, 3, 3, 20);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(288, 29);
            cbStatus.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 20);
            label2.Margin = new Padding(3, 0, 3, 20);
            label2.Name = "label2";
            label2.Size = new Size(685, 44);
            label2.TabIndex = 2;
            label2.Text = "Create Reservation";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 179);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 5;
            label1.Text = "Guest:";
            // 
            // cbPrimaryGuest
            // 
            cbPrimaryGuest.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbPrimaryGuest.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbPrimaryGuest.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPrimaryGuest.FormattingEnabled = true;
            cbPrimaryGuest.Location = new Point(79, 171);
            cbPrimaryGuest.Margin = new Padding(3, 3, 3, 20);
            cbPrimaryGuest.Name = "cbPrimaryGuest";
            cbPrimaryGuest.Size = new Size(359, 29);
            cbPrimaryGuest.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 147);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 7;
            label4.Text = "Primary Guest";
            // 
            // btnAddGuest
            // 
            btnAddGuest.BackColor = Color.FromArgb(83, 67, 199);
            btnAddGuest.FlatAppearance.BorderSize = 0;
            btnAddGuest.FlatStyle = FlatStyle.Flat;
            btnAddGuest.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddGuest.ForeColor = Color.White;
            btnAddGuest.Location = new Point(444, 171);
            btnAddGuest.Margin = new Padding(3, 3, 3, 20);
            btnAddGuest.Name = "btnAddGuest";
            btnAddGuest.Size = new Size(218, 29);
            btnAddGuest.TabIndex = 8;
            btnAddGuest.Text = "Add New Guest";
            btnAddGuest.UseVisualStyleBackColor = false;
            btnAddGuest.Click += btnAddGuest_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 220);
            label5.Name = "label5";
            label5.Size = new Size(145, 21);
            label5.TabIndex = 9;
            label5.Text = "Room Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 252);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 10;
            label6.Text = "Room Type:";
            // 
            // cbRoomType
            // 
            cbRoomType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbRoomType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Location = new Point(147, 244);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(220, 29);
            cbRoomType.TabIndex = 11;
            cbRoomType.SelectedIndexChanged += cbRoomType_SelectedIndexChanged;
            // 
            // cbRoom
            // 
            cbRoom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbRoom.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRoom.FormattingEnabled = true;
            cbRoom.Location = new Point(443, 244);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(220, 29);
            cbRoom.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(383, 252);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 12;
            label7.Text = "Room:";
            // 
            // checkinDate
            // 
            checkinDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkinDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkinDate.Format = DateTimePickerFormat.Short;
            checkinDate.Location = new Point(103, 366);
            checkinDate.Margin = new Padding(3, 3, 3, 20);
            checkinDate.Name = "checkinDate";
            checkinDate.Size = new Size(220, 29);
            checkinDate.TabIndex = 14;
            checkinDate.ValueChanged += checkinDate_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 374);
            label8.Name = "label8";
            label8.Size = new Size(74, 21);
            label8.TabIndex = 15;
            label8.Text = "Check-in:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(354, 374);
            label9.Name = "label9";
            label9.Size = new Size(84, 21);
            label9.TabIndex = 17;
            label9.Text = "Check-out:";
            // 
            // checkoutDate
            // 
            checkoutDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkoutDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkoutDate.Format = DateTimePickerFormat.Short;
            checkoutDate.Location = new Point(443, 366);
            checkoutDate.Margin = new Padding(3, 3, 3, 20);
            checkoutDate.Name = "checkoutDate";
            checkoutDate.Size = new Size(219, 29);
            checkoutDate.TabIndex = 16;
            checkoutDate.ValueChanged += checkoutDate_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(23, 415);
            label10.Name = "label10";
            label10.Size = new Size(59, 21);
            label10.TabIndex = 18;
            label10.Text = "Nights:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(23, 322);
            label15.Name = "label15";
            label15.Size = new Size(118, 21);
            label15.TabIndex = 25;
            label15.Text = "Room Capacity:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(23, 456);
            label16.Name = "label16";
            label16.Size = new Size(132, 21);
            label16.TabIndex = 31;
            label16.Text = "Additional Guest";
            // 
            // cbAdditionalGuest
            // 
            cbAdditionalGuest.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbAdditionalGuest.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbAdditionalGuest.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAdditionalGuest.FormattingEnabled = true;
            cbAdditionalGuest.Location = new Point(79, 480);
            cbAdditionalGuest.Name = "cbAdditionalGuest";
            cbAdditionalGuest.Size = new Size(359, 29);
            cbAdditionalGuest.TabIndex = 30;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(23, 488);
            label17.Name = "label17";
            label17.Size = new Size(53, 21);
            label17.TabIndex = 29;
            label17.Text = "Guest:";
            // 
            // btnAddNewGuestForAddtional
            // 
            btnAddNewGuestForAddtional.BackColor = Color.FromArgb(83, 67, 199);
            btnAddNewGuestForAddtional.FlatAppearance.BorderSize = 0;
            btnAddNewGuestForAddtional.FlatStyle = FlatStyle.Flat;
            btnAddNewGuestForAddtional.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewGuestForAddtional.ForeColor = Color.White;
            btnAddNewGuestForAddtional.Location = new Point(444, 649);
            btnAddNewGuestForAddtional.Margin = new Padding(3, 3, 3, 20);
            btnAddNewGuestForAddtional.Name = "btnAddNewGuestForAddtional";
            btnAddNewGuestForAddtional.Size = new Size(218, 29);
            btnAddNewGuestForAddtional.TabIndex = 32;
            btnAddNewGuestForAddtional.Text = "Add New Guest";
            btnAddNewGuestForAddtional.UseVisualStyleBackColor = false;
            btnAddNewGuestForAddtional.Click += btnAddNewGuestForAddtional_Click;
            // 
            // additionalGuestTable
            // 
            additionalGuestTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            additionalGuestTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            additionalGuestTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            additionalGuestTable.DefaultCellStyle = dataGridViewCellStyle2;
            additionalGuestTable.Location = new Point(23, 515);
            additionalGuestTable.Name = "additionalGuestTable";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            additionalGuestTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            additionalGuestTable.RowHeadersVisible = false;
            additionalGuestTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            additionalGuestTable.Size = new Size(640, 128);
            additionalGuestTable.TabIndex = 33;
            additionalGuestTable.CellClick += additionalGuestTable_CellClick;
            // 
            // btnAddToList
            // 
            btnAddToList.FlatStyle = FlatStyle.Flat;
            btnAddToList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddToList.Location = new Point(443, 479);
            btnAddToList.Name = "btnAddToList";
            btnAddToList.Size = new Size(219, 29);
            btnAddToList.TabIndex = 34;
            btnAddToList.Text = "Add to List";
            btnAddToList.UseVisualStyleBackColor = true;
            btnAddToList.Click += btnAddToList_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(23, 287);
            label11.Name = "label11";
            label11.Size = new Size(93, 21);
            label11.TabIndex = 35;
            label11.Text = "Room Price:";
            // 
            // txtPrice
            // 
            txtPrice.AutoSize = true;
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(147, 287);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(19, 21);
            txtPrice.TabIndex = 36;
            txtPrice.Text = "0";
            // 
            // txtCapacity
            // 
            txtCapacity.AutoSize = true;
            txtCapacity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCapacity.Location = new Point(147, 322);
            txtCapacity.Margin = new Padding(3, 0, 3, 20);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(19, 21);
            txtCapacity.TabIndex = 37;
            txtCapacity.Text = "0";
            // 
            // txtNights
            // 
            txtNights.AutoSize = true;
            txtNights.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNights.Location = new Point(99, 415);
            txtNights.Margin = new Padding(3, 0, 3, 20);
            txtNights.Name = "txtNights";
            txtNights.Size = new Size(19, 21);
            txtNights.TabIndex = 38;
            txtNights.Text = "0";
            // 
            // AddEditReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 827);
            Controls.Add(txtNights);
            Controls.Add(txtCapacity);
            Controls.Add(txtPrice);
            Controls.Add(label11);
            Controls.Add(btnAddToList);
            Controls.Add(additionalGuestTable);
            Controls.Add(btnAddNewGuestForAddtional);
            Controls.Add(label16);
            Controls.Add(cbAdditionalGuest);
            Controls.Add(label17);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(checkoutDate);
            Controls.Add(label8);
            Controls.Add(checkinDate);
            Controls.Add(cbRoom);
            Controls.Add(label7);
            Controls.Add(cbRoomType);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnAddGuest);
            Controls.Add(label4);
            Controls.Add(cbPrimaryGuest);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(cbStatus);
            Name = "AddEditReservation";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddEditReservation";
            Load += AddEditReservation_Load;
            ((System.ComponentModel.ISupportInitialize)additionalGuestTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private ComboBox cbStatus;
        private Label label2;
        private Label label1;
        private ComboBox cbPrimaryGuest;
        private Label label4;
        private Button btnAddGuest;
        private Label label5;
        private Label label6;
        private ComboBox cbRoomType;
        private ComboBox cbRoom;
        private Label label7;
        private DateTimePicker checkinDate;
        private Label label8;
        private Label label9;
        private DateTimePicker checkoutDate;
        private Label label10;
        private Label label15;
        private Label label16;
        private ComboBox cbAdditionalGuest;
        private Label label17;
        private Button btnAddNewGuestForAddtional;
        private DataGridView additionalGuestTable;
        private Button btnAddToList;
        private Label label11;
        private Label txtPrice;
        private Label txtCapacity;
        private Label txtNights;
    }
}