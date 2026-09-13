namespace HotelManagementSystem.UserControls
{
    partial class Rooms
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

        #region Component Designer generated code

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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label1 = new Label();
            roomsGrid = new DataGridView();
            panel2 = new Panel();
            btnRoomType = new Button();
            btnNext = new Button();
            btnSearch = new Button();
            btnFirst = new Button();
            lblPageInfo = new Label();
            btnPrev = new Button();
            btnLast = new Button();
            tbSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomsGrid).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(1224, 100);
            panel1.TabIndex = 0;
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
            btnDelete.Location = new Point(1085, 40);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 35);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Room";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = Color.FromArgb(83, 67, 199);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(957, 40);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(122, 35);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update Room";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.FromArgb(83, 67, 199);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(852, 40);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 35);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Room";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(228, 60);
            label1.TabIndex = 0;
            label1.Text = "Rooms";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // roomsGrid
            // 
            roomsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roomsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            roomsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            roomsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            roomsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            roomsGrid.Location = new Point(23, 75);
            roomsGrid.Margin = new Padding(3, 3, 3, 20);
            roomsGrid.MultiSelect = false;
            roomsGrid.Name = "roomsGrid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            roomsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            roomsGrid.RowHeadersVisible = false;
            roomsGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            roomsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roomsGrid.Size = new Size(1178, 605);
            roomsGrid.TabIndex = 1;
            roomsGrid.CellClick += roomsGrid_CellClick;
            roomsGrid.CellDoubleClick += roomsGrid_CellDoubleClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnRoomType);
            panel2.Controls.Add(btnNext);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnFirst);
            panel2.Controls.Add(lblPageInfo);
            panel2.Controls.Add(btnPrev);
            panel2.Controls.Add(btnLast);
            panel2.Controls.Add(tbSearch);
            panel2.Controls.Add(roomsGrid);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20);
            panel2.Size = new Size(1224, 761);
            panel2.TabIndex = 1;
            // 
            // btnRoomType
            // 
            btnRoomType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRoomType.AutoSize = true;
            btnRoomType.BackColor = Color.FromArgb(83, 67, 199);
            btnRoomType.FlatAppearance.BorderSize = 0;
            btnRoomType.FlatStyle = FlatStyle.Flat;
            btnRoomType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoomType.ForeColor = Color.White;
            btnRoomType.Location = new Point(1098, 16);
            btnRoomType.Name = "btnRoomType";
            btnRoomType.Size = new Size(103, 35);
            btnRoomType.TabIndex = 4;
            btnRoomType.Text = "Room Type";
            btnRoomType.UseVisualStyleBackColor = false;
            btnRoomType.Click += btnRoomType_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.BackColor = Color.Transparent;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(1136, 703);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(30, 35);
            btnNext.TabIndex = 16;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(435, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 29);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFirst.BackColor = Color.Transparent;
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFirst.Location = new Point(1064, 703);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(30, 35);
            btnFirst.TabIndex = 15;
            btnFirst.Text = "<<";
            btnFirst.UseVisualStyleBackColor = false;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageInfo.ForeColor = Color.FromArgb(64, 64, 64);
            lblPageInfo.Location = new Point(23, 710);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(197, 21);
            lblPageInfo.TabIndex = 3;
            lblPageInfo.Text = "Showing 1 to 6 of 6 entries";
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrev.BackColor = Color.Transparent;
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrev.Location = new Point(1100, 703);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(30, 35);
            btnPrev.TabIndex = 14;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLast.Location = new Point(1172, 703);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(30, 35);
            btnLast.TabIndex = 13;
            btnLast.Text = ">>";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(23, 23);
            tbSearch.Margin = new Padding(3, 3, 3, 20);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search rooms...";
            tbSearch.Size = new Size(487, 29);
            tbSearch.TabIndex = 2;
            // 
            // Rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "Rooms";
            Size = new Size(1224, 861);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roomsGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnAdd;
        private DataGridView roomsGrid;
        private Panel panel2;
        private TextBox tbSearch;
        private Label lblPageInfo;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnNext;
        private Button btnFirst;
        private Button btnPrev;
        private Button btnLast;
        private Button btnRoomType;
    }
}
