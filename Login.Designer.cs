namespace HotelManagementSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label5 = new Label();
            btnSignin = new Button();
            cbShowPassword = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btneXIT = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnSignin);
            panel1.Controls.Add(cbShowPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btneXIT);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(400, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 450);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(3, 390);
            label5.Name = "label5";
            label5.Size = new Size(394, 23);
            label5.TabIndex = 9;
            label5.Text = "@2026 Hotel Management System";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.FromArgb(83, 67, 199);
            btnSignin.FlatStyle = FlatStyle.Flat;
            btnSignin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignin.ForeColor = Color.White;
            btnSignin.Location = new Point(73, 304);
            btnSignin.Margin = new Padding(0);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(255, 35);
            btnSignin.TabIndex = 8;
            btnSignin.Text = "Sign In";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // cbShowPassword
            // 
            cbShowPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbShowPassword.AutoSize = true;
            cbShowPassword.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowPassword.Location = new Point(220, 256);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.RightToLeft = RightToLeft.Yes;
            cbShowPassword.Size = new Size(108, 17);
            cbShowPassword.TabIndex = 7;
            cbShowPassword.Text = "Show password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(73, 209);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(73, 145);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.Location = new Point(73, 227);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(255, 23);
            tbPassword.TabIndex = 4;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbUsername.Location = new Point(73, 163);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(255, 23);
            tbUsername.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(3, 97);
            label2.Name = "label2";
            label2.Size = new Size(394, 26);
            label2.TabIndex = 2;
            label2.Text = "Please sign in to continue";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 64);
            label1.Name = "label1";
            label1.Size = new Size(394, 33);
            label1.TabIndex = 1;
            label1.Text = "Welcome Back!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btneXIT
            // 
            btneXIT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btneXIT.FlatStyle = FlatStyle.Flat;
            btneXIT.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btneXIT.Location = new Point(370, 0);
            btneXIT.Name = "btneXIT";
            btneXIT.Size = new Size(30, 30);
            btneXIT.TabIndex = 0;
            btneXIT.Text = "X";
            btneXIT.UseVisualStyleBackColor = true;
            btneXIT.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btneXIT;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private CheckBox cbShowPassword;
        private Label label5;
        private Button btnSignin;
    }
}
