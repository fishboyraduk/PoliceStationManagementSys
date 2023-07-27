namespace Police
{
    partial class Cases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cases));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            LogoutBtn = new Button();
            label7 = new Label();
            panel3 = new Panel();
            CaseLbl = new Label();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            CaseDGV = new DataGridView();
            CancelBtn = new Button();
            EditBtn = new Button();
            SaveBtn = new Button();
            OffNameLbl = new Label();
            pictureBox7 = new PictureBox();
            label15 = new Label();
            CrimNameTb = new TextBox();
            CriminalCb = new ComboBox();
            label14 = new Label();
            Date = new DateTimePicker();
            label13 = new Label();
            CaseDetailsTb = new TextBox();
            label12 = new Label();
            caseheadTb = new TextBox();
            label11 = new Label();
            TypeCb = new ComboBox();
            label10 = new Label();
            PlaceTb = new TextBox();
            label9 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CaseDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // LogoutBtn
            // 
            LogoutBtn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutBtn.Location = new Point(19, 109);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(88, 32);
            LogoutBtn.TabIndex = 10;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(4, 13);
            label7.Name = "label7";
            label7.Size = new Size(124, 18);
            label7.TabIndex = 17;
            label7.Text = "CRIMINAL CASES";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOrange;
            panel3.Controls.Add(LogoutBtn);
            panel3.Controls.Add(CaseLbl);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(12, 446);
            panel3.Name = "panel3";
            panel3.Size = new Size(136, 153);
            panel3.TabIndex = 20;
            // 
            // CaseLbl
            // 
            CaseLbl.AutoSize = true;
            CaseLbl.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CaseLbl.Location = new Point(35, 31);
            CaseLbl.Name = "CaseLbl";
            CaseLbl.Size = new Size(59, 18);
            CaseLbl.TabIndex = 17;
            CaseLbl.Text = "Number";
            CaseLbl.Click += label8_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(83, 313);
            label5.Name = "label5";
            label5.Size = new Size(64, 16);
            label5.TabIndex = 29;
            label5.Text = "CHARGES";
            label5.Click += label5_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(15, 304);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(53, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(71, 19);
            label4.Name = "label4";
            label4.Size = new Size(45, 16);
            label4.TabIndex = 27;
            label4.Text = "CASES";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(83, 192);
            label3.Name = "label3";
            label3.Size = new Size(74, 16);
            label3.TabIndex = 25;
            label3.Text = "CRIMINALS";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(83, 138);
            label2.Name = "label2";
            label2.Size = new Size(55, 16);
            label2.TabIndex = 23;
            label2.Text = "OFFICER";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 115);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(83, 35);
            label1.Name = "label1";
            label1.Size = new Size(55, 16);
            label1.TabIndex = 3;
            label1.Text = "Database";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(15, 180);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrange;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(15, 238);
            panel2.Name = "panel2";
            panel2.Size = new Size(139, 47);
            panel2.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(CaseDGV);
            panel1.Controls.Add(CancelBtn);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(SaveBtn);
            panel1.Controls.Add(OffNameLbl);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(CrimNameTb);
            panel1.Controls.Add(CriminalCb);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(Date);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(CaseDetailsTb);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(caseheadTb);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(TypeCb);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(PlaceTb);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(163, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 587);
            panel1.TabIndex = 21;
            // 
            // CaseDGV
            // 
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CaseDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CaseDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CaseDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CaseDGV.Location = new Point(17, 277);
            CaseDGV.Name = "CaseDGV";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CaseDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CaseDGV.RowTemplate.Height = 25;
            CaseDGV.Size = new Size(1031, 298);
            CaseDGV.TabIndex = 55;
            CaseDGV.CellContentClick += CaseDGV_CellContentClick;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(575, 229);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(88, 32);
            CancelBtn.TabIndex = 53;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(341, 230);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(88, 32);
            EditBtn.TabIndex = 52;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(460, 230);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(88, 32);
            SaveBtn.TabIndex = 51;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // OffNameLbl
            // 
            OffNameLbl.AutoSize = true;
            OffNameLbl.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            OffNameLbl.Location = new Point(832, 23);
            OffNameLbl.Name = "OffNameLbl";
            OffNameLbl.Size = new Size(59, 16);
            OffNameLbl.TabIndex = 49;
            OffNameLbl.Text = "OffName";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(785, 18);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(42, 43);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 48;
            pictureBox7.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.Location = new Point(784, 139);
            label15.Name = "label15";
            label15.Size = new Size(42, 16);
            label15.TabIndex = 47;
            label15.Text = "NAME";
            // 
            // CrimNameTb
            // 
            CrimNameTb.Enabled = false;
            CrimNameTb.Location = new Point(784, 158);
            CrimNameTb.Name = "CrimNameTb";
            CrimNameTb.Size = new Size(264, 27);
            CrimNameTb.TabIndex = 46;
            // 
            // CriminalCb
            // 
            CriminalCb.FormattingEnabled = true;
            CriminalCb.Location = new Point(784, 103);
            CriminalCb.Name = "CriminalCb";
            CriminalCb.Size = new Size(264, 29);
            CriminalCb.TabIndex = 45;
            CriminalCb.SelectionChangeCommitted += CriminalCb_SelectionChangeCommitted;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(784, 82);
            label14.Name = "label14";
            label14.Size = new Size(118, 16);
            label14.TabIndex = 43;
            label14.Text = "PERSONS INVOLVED";
            // 
            // Date
            // 
            Date.CalendarMonthBackground = Color.DarkOrange;
            Date.Location = new Point(287, 159);
            Date.Name = "Date";
            Date.Size = new Size(214, 27);
            Date.TabIndex = 42;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(222, 81);
            label13.Name = "label13";
            label13.Size = new Size(93, 16);
            label13.TabIndex = 41;
            label13.Text = "CASE HEADING";
            // 
            // CaseDetailsTb
            // 
            CaseDetailsTb.Location = new Point(514, 100);
            CaseDetailsTb.Multiline = true;
            CaseDetailsTb.Name = "CaseDetailsTb";
            CaseDetailsTb.Size = new Size(264, 85);
            CaseDetailsTb.TabIndex = 40;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(514, 81);
            label12.Name = "label12";
            label12.Size = new Size(82, 16);
            label12.TabIndex = 39;
            label12.Text = "CASE DETAILS";
            // 
            // caseheadTb
            // 
            caseheadTb.Location = new Point(222, 100);
            caseheadTb.Name = "caseheadTb";
            caseheadTb.Size = new Size(264, 27);
            caseheadTb.TabIndex = 38;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(17, 139);
            label11.Name = "label11";
            label11.Size = new Size(100, 16);
            label11.TabIndex = 37;
            label11.Text = "CASE LOCATION";
            // 
            // TypeCb
            // 
            TypeCb.FormattingEnabled = true;
            TypeCb.Items.AddRange(new object[] { "Criminal", "Fraud", "Financial Fraud", "Drug dealing", "Violence", "Gun Violence", "Other" });
            TypeCb.Location = new Point(17, 98);
            TypeCb.Name = "TypeCb";
            TypeCb.Size = new Size(178, 29);
            TypeCb.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(17, 79);
            label10.Name = "label10";
            label10.Size = new Size(65, 16);
            label10.TabIndex = 35;
            label10.Text = "CASE TYPE";
            // 
            // PlaceTb
            // 
            PlaceTb.Location = new Point(17, 158);
            PlaceTb.Name = "PlaceTb";
            PlaceTb.Size = new Size(264, 27);
            PlaceTb.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(17, 18);
            label9.Name = "label9";
            label9.Size = new Size(134, 21);
            label9.TabIndex = 33;
            label9.Text = "MANAGE CASES";
            // 
            // Cases
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1242, 611);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Cases";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cases";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CaseDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogoutBtn;
        private Label label7;
        private Panel panel3;
        private Label CaseLbl;
        private Label label5;
        private PictureBox pictureBox5;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Panel panel1;
        private Label label9;
        private TextBox PlaceTb;
        private Label label11;
        private ComboBox TypeCb;
        private Label label10;
        private DateTimePicker Date;
        private Label label13;
        private TextBox CaseDetailsTb;
        private Label label12;
        private TextBox caseheadTb;
        private Label label15;
        private TextBox CrimNameTb;
        private ComboBox CriminalCb;
        private Label label14;
        private Label OffNameLbl;
        private PictureBox pictureBox7;
        private Button CancelBtn;
        private Button EditBtn;
        private Button SaveBtn;
        private DataGridView CaseDGV;
    }
}