namespace HotelManagementSystem.UserControls
{
    partial class Guests
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnDeleteGuest = new Button();
            btnUpdateGuest = new Button();
            btnAddGuest = new Button();
            label1 = new Label();
            panel2 = new Panel();
            btnNext = new Button();
            btnFirst = new Button();
            btnSearch = new Button();
            btnPrev = new Button();
            btnLast = new Button();
            lblPageInfo = new Label();
            tbSearch = new TextBox();
            guestsGrid = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guestsGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDeleteGuest);
            panel1.Controls.Add(btnUpdateGuest);
            panel1.Controls.Add(btnAddGuest);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(1224, 100);
            panel1.TabIndex = 1;
            // 
            // btnDeleteGuest
            // 
            btnDeleteGuest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteGuest.AutoSize = true;
            btnDeleteGuest.BackColor = Color.Red;
            btnDeleteGuest.FlatAppearance.BorderSize = 0;
            btnDeleteGuest.FlatStyle = FlatStyle.Flat;
            btnDeleteGuest.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteGuest.ForeColor = Color.White;
            btnDeleteGuest.Location = new Point(1081, 40);
            btnDeleteGuest.Name = "btnDeleteGuest";
            btnDeleteGuest.Size = new Size(120, 35);
            btnDeleteGuest.TabIndex = 2;
            btnDeleteGuest.Text = "Delete Guest";
            btnDeleteGuest.UseVisualStyleBackColor = false;
            btnDeleteGuest.Click += btnDeleteGuest_Click;
            // 
            // btnUpdateGuest
            // 
            btnUpdateGuest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateGuest.AutoSize = true;
            btnUpdateGuest.BackColor = Color.FromArgb(83, 67, 199);
            btnUpdateGuest.FlatAppearance.BorderSize = 0;
            btnUpdateGuest.FlatStyle = FlatStyle.Flat;
            btnUpdateGuest.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateGuest.ForeColor = Color.White;
            btnUpdateGuest.Location = new Point(955, 40);
            btnUpdateGuest.Name = "btnUpdateGuest";
            btnUpdateGuest.Size = new Size(120, 35);
            btnUpdateGuest.TabIndex = 1;
            btnUpdateGuest.Text = "Update Guest";
            btnUpdateGuest.UseVisualStyleBackColor = false;
            btnUpdateGuest.Click += btnUpdateGuest_Click;
            // 
            // btnAddGuest
            // 
            btnAddGuest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddGuest.AutoSize = true;
            btnAddGuest.BackColor = Color.FromArgb(83, 67, 199);
            btnAddGuest.FlatAppearance.BorderSize = 0;
            btnAddGuest.FlatStyle = FlatStyle.Flat;
            btnAddGuest.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddGuest.ForeColor = Color.White;
            btnAddGuest.Location = new Point(829, 40);
            btnAddGuest.Name = "btnAddGuest";
            btnAddGuest.Size = new Size(120, 35);
            btnAddGuest.TabIndex = 0;
            btnAddGuest.Text = "Add Guest";
            btnAddGuest.UseVisualStyleBackColor = false;
            btnAddGuest.Click += btnAddGuest_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(228, 60);
            label1.TabIndex = 0;
            label1.Text = "Guests";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNext);
            panel2.Controls.Add(btnFirst);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnPrev);
            panel2.Controls.Add(btnLast);
            panel2.Controls.Add(lblPageInfo);
            panel2.Controls.Add(tbSearch);
            panel2.Controls.Add(guestsGrid);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20);
            panel2.Size = new Size(1224, 761);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.BackColor = Color.Transparent;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(1135, 703);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(30, 35);
            btnNext.TabIndex = 12;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFirst.BackColor = Color.Transparent;
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFirst.Location = new Point(1063, 703);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(30, 35);
            btnFirst.TabIndex = 11;
            btnFirst.Text = "<<";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(435, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 29);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrev.BackColor = Color.Transparent;
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrev.Location = new Point(1099, 703);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(30, 35);
            btnPrev.TabIndex = 8;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLast.Location = new Point(1171, 703);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(30, 35);
            btnLast.TabIndex = 7;
            btnLast.Text = ">>";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
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
            lblPageInfo.TabIndex = 5;
            lblPageInfo.Text = "Showing 1 to 6 of 6 entries";
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(23, 23);
            tbSearch.Margin = new Padding(3, 3, 3, 20);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search guest name...";
            tbSearch.Size = new Size(487, 29);
            tbSearch.TabIndex = 4;
            tbSearch.KeyDown += tbSearch_KeyDown;
            // 
            // guestsGrid
            // 
            guestsGrid.AllowUserToResizeColumns = false;
            guestsGrid.AllowUserToResizeRows = false;
            guestsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guestsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            guestsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            guestsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guestsGrid.GridColor = SystemColors.InactiveCaption;
            guestsGrid.Location = new Point(23, 75);
            guestsGrid.Margin = new Padding(3, 3, 3, 20);
            guestsGrid.MultiSelect = false;
            guestsGrid.Name = "guestsGrid";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            guestsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            guestsGrid.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guestsGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            guestsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            guestsGrid.Size = new Size(1178, 605);
            guestsGrid.TabIndex = 3;
            guestsGrid.CellDoubleClick += guestsGrid_CellDoubleClick;
            // 
            // Guests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Guests";
            Size = new Size(1224, 861);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guestsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAddGuest;
        private Label label1;
        private Panel panel2;
        private TextBox tbSearch;
        private DataGridView guestsGrid;
        private Label lblPageInfo;
        private Button btnPrev;
        private Button btnLast;
        private Button btnDeleteGuest;
        private Button btnUpdateGuest;
        private Button btnSearch;
        private Button btnNext;
        private Button btnFirst;
    }
}
