namespace Police
{
    partial class Criminals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Criminals));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label5 = new Label();
            CaseLbl = new Label();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            LogoutBtn = new Button();
            label4 = new Label();
            panel1 = new Panel();
            ActivityTb = new TextBox();
            label11 = new Label();
            NameTb = new TextBox();
            CancelBtn = new Button();
            EditBtn = new Button();
            SaveBtn = new Button();
            CriminalDGV = new DataGridView();
            pictureBox7 = new PictureBox();
            AddressTb = new TextBox();
            label12 = new Label();
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
            OffNameLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CriminalDGV).BeginInit();
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
            label5.Location = new Point(85, 306);
            label5.Name = "label5";
            label5.Size = new Size(64, 16);
            label5.TabIndex = 57;
            label5.Text = "CHARGES";
            label5.Click += label5_Click;
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
            panel1.Controls.Add(OffNameLbl);
            panel1.Controls.Add(ActivityTb);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(NameTb);
            panel1.Controls.Add(CancelBtn);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(SaveBtn);
            panel1.Controls.Add(CriminalDGV);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(AddressTb);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(165, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 587);
            panel1.TabIndex = 51;
            // 
            // ActivityTb
            // 
            ActivityTb.Location = new Point(542, 98);
            ActivityTb.Multiline = true;
            ActivityTb.Name = "ActivityTb";
            ActivityTb.Size = new Size(264, 85);
            ActivityTb.TabIndex = 56;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(542, 79);
            label11.Name = "label11";
            label11.Size = new Size(124, 16);
            label11.TabIndex = 55;
            label11.Text = "ACTIVITIES INVOLVED";
            // 
            // NameTb
            // 
            NameTb.Location = new Point(17, 100);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(191, 27);
            NameTb.TabIndex = 54;
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
            EditBtn.Location = new Point(310, 229);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(88, 32);
            EditBtn.TabIndex = 52;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(447, 229);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(88, 32);
            SaveBtn.TabIndex = 51;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CriminalDGV
            // 
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CriminalDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CriminalDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CriminalDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CriminalDGV.Location = new Point(17, 277);
            CriminalDGV.Name = "CriminalDGV";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CriminalDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CriminalDGV.RowTemplate.Height = 25;
            CriminalDGV.Size = new Size(1031, 298);
            CriminalDGV.TabIndex = 50;
            CriminalDGV.CellContentClick += CriminalDGV_CellContentClick;
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
            // AddressTb
            // 
            AddressTb.Location = new Point(246, 98);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(264, 85);
            AddressTb.TabIndex = 40;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(246, 79);
            label12.Name = "label12";
            label12.Size = new Size(57, 16);
            label12.TabIndex = 39;
            label12.Text = "ADDRESS";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(17, 79);
            label10.Name = "label10";
            label10.Size = new Size(42, 16);
            label10.TabIndex = 35;
            label10.Text = "NAME";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(17, 18);
            label9.Name = "label9";
            label9.Size = new Size(169, 21);
            label9.TabIndex = 33;
            label9.Text = "MANAGE CRIMINALS";
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
            label2.Location = new Point(85, 132);
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
            label3.BackColor = Color.DarkOrange;
            label3.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(59, 15);
            label3.Name = "label3";
            label3.Size = new Size(74, 16);
            label3.TabIndex = 55;
            label3.Text = "CRIMINALS";
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
            pictureBox2.Location = new Point(17, 109);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 56;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrange;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(17, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(145, 47);
            panel2.TabIndex = 52;
            // 
            // OffNameLbl
            // 
            OffNameLbl.AutoSize = true;
            OffNameLbl.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            OffNameLbl.Location = new Point(833, 18);
            OffNameLbl.Name = "OffNameLbl";
            OffNameLbl.Size = new Size(59, 16);
            OffNameLbl.TabIndex = 57;
            OffNameLbl.Text = "OffName";
            // 
            // Criminals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1243, 597);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Criminals";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Criminals";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CriminalDGV).EndInit();
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
        private Label label8;
        private Label label6;
        private PictureBox pictureBox6;
        private Label label7;
        private PictureBox pictureBox5;
        private Button LogoutBtn;
        private Label label4;
        private TextBox NameTb;
        private Button CancelBtn;
        private Button EditBtn;
        private Button SaveBtn;
        private DataGridView CriminalDGV;
        private PictureBox pictureBox7;
        private TextBox AddressTb;
        private Label label12;
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
        private TextBox ActivityTb;
        private Label label11;
        internal Panel panel1;
        private Label OffNameLbl;
    }
}