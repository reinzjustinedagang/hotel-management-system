namespace HotelManagementSystem.UserControls
{
    partial class CheckIn
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
            panel1 = new Panel();
            btnCheckIn = new Button();
            label1 = new Label();
            panel2 = new Panel();
            lblPageInfo = new Label();
            btnNext = new Button();
            btnFirst = new Button();
            btnPrev = new Button();
            btnLast = new Button();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            tbSearch = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCheckIn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(1145, 100);
            panel1.TabIndex = 0;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCheckIn.AutoSize = true;
            btnCheckIn.BackColor = Color.FromArgb(83, 67, 199);
            btnCheckIn.FlatAppearance.BorderSize = 0;
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckIn.ForeColor = Color.White;
            btnCheckIn.Location = new Point(988, 40);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(134, 35);
            btnCheckIn.TabIndex = 2;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(228, 60);
            label1.TabIndex = 1;
            label1.Text = "Check In";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPageInfo);
            panel2.Controls.Add(btnNext);
            panel2.Controls.Add(btnFirst);
            panel2.Controls.Add(btnPrev);
            panel2.Controls.Add(btnLast);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(tbSearch);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20);
            panel2.Size = new Size(1145, 621);
            panel2.TabIndex = 1;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageInfo.ForeColor = Color.FromArgb(64, 64, 64);
            lblPageInfo.Location = new Point(23, 568);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(197, 21);
            lblPageInfo.TabIndex = 4;
            lblPageInfo.Text = "Showing 1 to 6 of 6 entries";
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.BackColor = Color.Transparent;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(1056, 561);
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
            btnFirst.Location = new Point(984, 561);
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
            btnPrev.Location = new Point(1020, 561);
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
            btnLast.Location = new Point(1092, 561);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(30, 35);
            btnLast.TabIndex = 17;
            btnLast.Text = ">>";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 75);
            dataGridView1.Margin = new Padding(3, 3, 3, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1099, 463);
            dataGridView1.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(435, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(23, 23);
            tbSearch.Margin = new Padding(3, 3, 3, 20);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(487, 29);
            tbSearch.TabIndex = 0;
            // 
            // CheckIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CheckIn";
            Size = new Size(1145, 721);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnCheckIn;
        private Panel panel2;
        private TextBox tbSearch;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Button btnNext;
        private Button btnFirst;
        private Button btnPrev;
        private Button btnLast;
        private Label lblPageInfo;
    }
}
