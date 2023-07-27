namespace Police
{
    partial class Charges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Charges));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label5 = new Label();
            CaseLbl = new Label();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            LogoutBtn = new Button();
            label4 = new Label();
            panel1 = new Panel();
            ChargeDGV = new DataGridView();
            CancelBtn = new Button();
            EditBtn = new Button();
            RecordBtn = new Button();
            OffNameLbl = new Label();
            pictureBox7 = new PictureBox();
            RemarksTb = new TextBox();
            label14 = new Label();
            label13 = new Label();
            ChargeSheetTb = new TextBox();
            label12 = new Label();
            CaseHeadingTb = new TextBox();
            CaseCb = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChargeDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(62, 16);
            label5.Name = "label5";
            label5.Size = new Size(64, 16);
            label5.TabIndex = 57;
            label5.Text = "CHARGES";
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
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(17, 297);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(53, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 58;
            pictureBox5.TabStop = false;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Location = new Point(19, 109);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(88, 32);
            LogoutBtn.TabIndex = 10;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(85, 250);
            label4.Name = "label4";
            label4.Size = new Size(45, 16);
            label4.TabIndex = 46;
            label4.Text = "CASES";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ChargeDGV);
            panel1.Controls.Add(CancelBtn);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(RecordBtn);
            panel1.Controls.Add(OffNameLbl);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(RemarksTb);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(ChargeSheetTb);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(CaseHeadingTb);
            panel1.Controls.Add(CaseCb);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(165, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 587);
            panel1.TabIndex = 51;
            // 
            // ChargeDGV
            // 
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ChargeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            ChargeDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ChargeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ChargeDGV.Location = new Point(17, 276);
            ChargeDGV.Name = "ChargeDGV";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ChargeDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ChargeDGV.RowTemplate.Height = 25;
            ChargeDGV.Size = new Size(1031, 298);
            ChargeDGV.TabIndex = 55;
            ChargeDGV.CellContentClick += ChargeDGV_CellContentClick;
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
            EditBtn.Location = new Point(332, 228);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(88, 32);
            EditBtn.TabIndex = 52;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // RecordBtn
            // 
            RecordBtn.Location = new Point(455, 228);
            RecordBtn.Name = "RecordBtn";
            RecordBtn.Size = new Size(88, 32);
            RecordBtn.TabIndex = 51;
            RecordBtn.Text = "Save";
            RecordBtn.UseVisualStyleBackColor = true;
            RecordBtn.Click += RecordBtn_Click;
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
            // RemarksTb
            // 
            RemarksTb.Location = new Point(784, 100);
            RemarksTb.Multiline = true;
            RemarksTb.Name = "RemarksTb";
            RemarksTb.Size = new Size(264, 85);
            RemarksTb.TabIndex = 46;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(784, 82);
            label14.Name = "label14";
            label14.Size = new Size(60, 16);
            label14.TabIndex = 43;
            label14.Text = "REMARKS";
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
            // ChargeSheetTb
            // 
            ChargeSheetTb.Location = new Point(514, 100);
            ChargeSheetTb.Multiline = true;
            ChargeSheetTb.Name = "ChargeSheetTb";
            ChargeSheetTb.Size = new Size(264, 85);
            ChargeSheetTb.TabIndex = 40;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(514, 81);
            label12.Name = "label12";
            label12.Size = new Size(90, 16);
            label12.TabIndex = 39;
            label12.Text = "CHARGE SHEET";
            // 
            // CaseHeadingTb
            // 
            CaseHeadingTb.Location = new Point(222, 100);
            CaseHeadingTb.Name = "CaseHeadingTb";
            CaseHeadingTb.Size = new Size(264, 23);
            CaseHeadingTb.TabIndex = 38;
            // 
            // CaseCb
            // 
            CaseCb.FormattingEnabled = true;
            CaseCb.Location = new Point(17, 98);
            CaseCb.Name = "CaseCb";
            CaseCb.Size = new Size(178, 23);
            CaseCb.TabIndex = 36;
            CaseCb.SelectionChangeCommitted += CaseCb_SelectionChangeCommitted;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(17, 79);
            label10.Name = "label10";
            label10.Size = new Size(73, 16);
            label10.TabIndex = 35;
            label10.Text = "CASE CODE";
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
            // panel3
            // 
            panel3.BackColor = Color.DarkOrange;
            panel3.Controls.Add(LogoutBtn);
            panel3.Controls.Add(CaseLbl);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(14, 439);
            panel3.Name = "panel3";
            panel3.Size = new Size(136, 153);
            panel3.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(85, 131);
            label2.Name = "label2";
            label2.Size = new Size(55, 16);
            label2.TabIndex = 53;
            label2.Text = "OFFICER";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 28);
            label1.Name = "label1";
            label1.Size = new Size(55, 16);
            label1.TabIndex = 48;
            label1.Text = "Database";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(85, 185);
            label3.Name = "label3";
            label3.Size = new Size(74, 16);
            label3.TabIndex = 55;
            label3.Text = "CRIMINALS";
            label3.Click += label3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 234);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 47;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 108);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(17, 173);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 56;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrange;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(14, 297);
            panel2.Name = "panel2";
            panel2.Size = new Size(139, 47);
            panel2.TabIndex = 52;
            // 
            // Charges
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1243, 597);
            Controls.Add(pictureBox5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Charges";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Charges";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ChargeDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label CaseLbl;
        private Label label7;
        private PictureBox pictureBox5;
        private Button LogoutBtn;
        private Label label4;
        private Panel panel1;
        private Button CancelBtn;
        private Button EditBtn;
        private Button RecordBtn;
        private Label OffNameLbl;
        private PictureBox pictureBox7;
        private TextBox RemarksTb;
        private Label label14;
        private Label label13;
        private TextBox ChargeSheetTb;
        private Label label12;
        private TextBox CaseHeadingTb;
        private ComboBox CaseCb;
        private Label label10;
        private Label label9;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel2;
        private DataGridView ChargeDGV;
    }
}