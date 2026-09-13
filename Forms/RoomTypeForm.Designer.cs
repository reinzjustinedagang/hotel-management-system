namespace HotelManagementSystem.Forms
{
    partial class RoomTypeForm
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
            panel1 = new Panel();
            btnExit = new Button();
            label1 = new Label();
            btnDelete = new Button();
            btnAdd = new Button();
            roomTypeGrid = new DataGridView();
            tbName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numCapacity = new NumericUpDown();
            numBasePrice = new NumericUpDown();
            btnUpdate = new Button();
            btnClear = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomTypeGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBasePrice).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 81);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(642, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(89, 50);
            btnExit.TabIndex = 7;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(196, 41);
            label1.TabIndex = 1;
            label1.Text = "Room Type";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(525, 87);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(194, 35);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete Room Type";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.FromArgb(83, 67, 199);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(209, 532);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 35);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // roomTypeGrid
            // 
            roomTypeGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roomTypeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            roomTypeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            roomTypeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            roomTypeGrid.DefaultCellStyle = dataGridViewCellStyle2;
            roomTypeGrid.Location = new Point(12, 128);
            roomTypeGrid.MultiSelect = false;
            roomTypeGrid.Name = "roomTypeGrid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            roomTypeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            roomTypeGrid.RowHeadersVisible = false;
            roomTypeGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roomTypeGrid.Size = new Size(707, 258);
            roomTypeGrid.TabIndex = 1;
            roomTypeGrid.CellClick += roomTypeGrid_CellClick;
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.Location = new Point(209, 427);
            tbName.Name = "tbName";
            tbName.Size = new Size(333, 29);
            tbName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 435);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 7;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(120, 470);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 8;
            label3.Text = "Capacity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(120, 505);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 9;
            label4.Text = "Base Price:";
            // 
            // numCapacity
            // 
            numCapacity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numCapacity.Location = new Point(209, 462);
            numCapacity.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(333, 29);
            numCapacity.TabIndex = 10;
            // 
            // numBasePrice
            // 
            numBasePrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numBasePrice.Location = new Point(209, 497);
            numBasePrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numBasePrice.Name = "numBasePrice";
            numBasePrice.Size = new Size(333, 29);
            numBasePrice.TabIndex = 11;
            numBasePrice.ThousandsSeparator = true;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = Color.FromArgb(83, 67, 199);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(322, 532);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 35);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.BackColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(435, 532);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 35);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // RoomTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(731, 598);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(numBasePrice);
            Controls.Add(numCapacity);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(btnDelete);
            Controls.Add(roomTypeGrid);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoomTypeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RoomTypeForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roomTypeGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBasePrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView roomTypeGrid;
        private Button btnExit;
        private TextBox tbName;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numCapacity;
        private NumericUpDown numBasePrice;
        private Button btnUpdate;
        private Button btnClear;
    }
}