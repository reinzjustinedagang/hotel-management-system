namespace HotelManagementSystem.UserControls
{
    partial class Reservations
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
            label1 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            panel2 = new Panel();
            btnNext = new Button();
            btnFirst = new Button();
            btnPrev = new Button();
            btnLast = new Button();
            lblPageInfo = new Label();
            reservationsGrid = new DataGridView();
            btnSearch = new Button();
            tbSearch = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservationsGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(1152, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(228, 60);
            label1.TabIndex = 7;
            label1.Text = "Reservations";
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
            btnDelete.Location = new Point(963, 40);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(166, 35);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete Reservations";
            btnDelete.UseVisualStyleBackColor = false;
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
            btnUpdate.Location = new Point(785, 40);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(172, 35);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update Reservations";
            btnUpdate.UseVisualStyleBackColor = false;
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
            btnAdd.Location = new Point(628, 40);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "New Reservations";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNext);
            panel2.Controls.Add(btnFirst);
            panel2.Controls.Add(btnPrev);
            panel2.Controls.Add(btnLast);
            panel2.Controls.Add(lblPageInfo);
            panel2.Controls.Add(reservationsGrid);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(tbSearch);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20);
            panel2.Size = new Size(1152, 606);
            panel2.TabIndex = 1;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.BackColor = Color.Transparent;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(1063, 548);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(30, 35);
            btnNext.TabIndex = 20;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFirst.BackColor = Color.Transparent;
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFirst.Location = new Point(991, 548);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(30, 35);
            btnFirst.TabIndex = 19;
            btnFirst.Text = "<<";
            btnFirst.UseVisualStyleBackColor = false;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrev.BackColor = Color.Transparent;
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrev.Location = new Point(1027, 548);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(30, 35);
            btnPrev.TabIndex = 18;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLast.Location = new Point(1099, 548);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(30, 35);
            btnLast.TabIndex = 17;
            btnLast.Text = ">>";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageInfo.ForeColor = Color.FromArgb(64, 64, 64);
            lblPageInfo.Location = new Point(23, 555);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(197, 21);
            lblPageInfo.TabIndex = 4;
            lblPageInfo.Text = "Showing 1 to 6 of 6 entries";
            // 
            // reservationsGrid
            // 
            reservationsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reservationsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            reservationsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            reservationsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            reservationsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            reservationsGrid.Location = new Point(23, 75);
            reservationsGrid.Margin = new Padding(3, 3, 3, 20);
            reservationsGrid.MultiSelect = false;
            reservationsGrid.Name = "reservationsGrid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            reservationsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            reservationsGrid.RowHeadersVisible = false;
            reservationsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservationsGrid.Size = new Size(1106, 450);
            reservationsGrid.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(435, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 29);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(23, 23);
            tbSearch.Margin = new Padding(3, 3, 3, 20);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search reservations...";
            tbSearch.Size = new Size(487, 29);
            tbSearch.TabIndex = 12;
            // 
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Reservations";
            Size = new Size(1152, 706);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reservationsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private Panel panel2;
        private Button btnSearch;
        private TextBox tbSearch;
        private DataGridView reservationsGrid;
        private Label lblPageInfo;
        private Button btnNext;
        private Button btnFirst;
        private Button btnPrev;
        private Button btnLast;
    }
}
