namespace Police
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            ExitBtn = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            UsernameTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            PasswordTb = new TextBox();
            RoleCb = new ComboBox();
            pictureBox1 = new PictureBox();
            LoginBtn = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ExitBtn);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 351);
            panel1.TabIndex = 0;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(77, 3);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(47, 32);
            ExitBtn.TabIndex = 10;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(253, 19);
            label1.Name = "label1";
            label1.Size = new Size(215, 22);
            label1.TabIndex = 2;
            label1.Text = "Police Management System";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(206, 53);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(305, 2);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // UsernameTb
            // 
            UsernameTb.Location = new Point(253, 191);
            UsernameTb.Name = "UsernameTb";
            UsernameTb.Size = new Size(189, 27);
            UsernameTb.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(206, 166);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 4;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(206, 221);
            label3.Name = "label3";
            label3.Size = new Size(81, 22);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(253, 260);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*';
            PasswordTb.Size = new Size(189, 27);
            PasswordTb.TabIndex = 6;
            // 
            // RoleCb
            // 
            RoleCb.FormattingEnabled = true;
            RoleCb.Items.AddRange(new object[] { "Admin", "Officer" });
            RoleCb.Location = new Point(253, 134);
            RoleCb.Name = "RoleCb";
            RoleCb.Size = new Size(189, 29);
            RoleCb.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(310, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(303, 307);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(88, 32);
            LoginBtn.TabIndex = 9;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 316);
            label4.Name = "label4";
            label4.Size = new Size(136, 18);
            label4.TabIndex = 11;
            label4.Text = "Developed by Raduk";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 351);
            Controls.Add(LoginBtn);
            Controls.Add(pictureBox1);
            Controls.Add(RoleCb);
            Controls.Add(PasswordTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(UsernameTb);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox UsernameTb;
        private Label label2;
        private Label label3;
        private TextBox PasswordTb;
        private ComboBox RoleCb;
        private PictureBox pictureBox1;
        private Button LoginBtn;
        private Button ExitBtn;
        private Label label4;
    }
}