namespace NhomLatDat
{
    partial class Xử_Lý_Vi_Phạm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xử_Lý_Vi_Phạm));
            Xóa_btn = new Button();
            Sua_Btn = new Button();
            Them_Btn = new Button();
            groupBox2 = new GroupBox();
            TimKiemTen_Btn = new Button();
            TimKiemTen_Texbox = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            MaNV_ComboBox = new ComboBox();
            label8 = new Label();
            NgayMuon_Date = new DateTimePicker();
            MaXL_Textbox = new TextBox();
            label4 = new Label();
            Thoat_Btn = new Button();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            groupBox3 = new GroupBox();
            matra_combobox = new ComboBox();
            MaDocGia_Combobox = new ComboBox();
            LyDoVP_Textbox = new TextBox();
            label5 = new Label();
            trảSáchToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            menuStrip1 = new MenuStrip();
            mượnSáchToolStripMenuItem = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Xóa_btn
            // 
            Xóa_btn.Location = new Point(270, 25);
            Xóa_btn.Name = "Xóa_btn";
            Xóa_btn.Size = new Size(94, 29);
            Xóa_btn.TabIndex = 4;
            Xóa_btn.Text = "Xóa";
            Xóa_btn.UseVisualStyleBackColor = true;
            Xóa_btn.Click += Xóa_btn_Click;
            // 
            // Sua_Btn
            // 
            Sua_Btn.Location = new Point(170, 25);
            Sua_Btn.Name = "Sua_Btn";
            Sua_Btn.Size = new Size(94, 29);
            Sua_Btn.TabIndex = 1;
            Sua_Btn.Text = "Sửa";
            Sua_Btn.UseVisualStyleBackColor = true;
            Sua_Btn.Click += Sua_Btn_Click;
            // 
            // Them_Btn
            // 
            Them_Btn.Location = new Point(70, 25);
            Them_Btn.Name = "Them_Btn";
            Them_Btn.Size = new Size(94, 29);
            Them_Btn.TabIndex = 0;
            Them_Btn.Text = "Thêm";
            Them_Btn.UseVisualStyleBackColor = true;
            Them_Btn.Click += Them_Btn_Click;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(TimKiemTen_Btn);
            groupBox2.Controls.Add(TimKiemTen_Texbox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 318);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(744, 245);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // TimKiemTen_Btn
            // 
            TimKiemTen_Btn.Location = new Point(331, 25);
            TimKiemTen_Btn.Name = "TimKiemTen_Btn";
            TimKiemTen_Btn.Size = new Size(91, 26);
            TimKiemTen_Btn.TabIndex = 16;
            TimKiemTen_Btn.Text = "Tìm Kiếm";
            TimKiemTen_Btn.UseVisualStyleBackColor = true;
            TimKiemTen_Btn.Click += TimKiemTen_Btn_Click;
            // 
            // TimKiemTen_Texbox
            // 
            TimKiemTen_Texbox.Location = new Point(119, 26);
            TimKiemTen_Texbox.Name = "TimKiemTen_Texbox";
            TimKiemTen_Texbox.PlaceholderText = "Nhập Tên Muốn Tìm Kiếm";
            TimKiemTen_Texbox.Size = new Size(206, 27);
            TimKiemTen_Texbox.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 30);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 18;
            label7.Text = "Tìm Kiếm:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(672, 160);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // MaNV_ComboBox
            // 
            MaNV_ComboBox.FormattingEnabled = true;
            MaNV_ComboBox.Items.AddRange(new object[] { "1" });
            MaNV_ComboBox.Location = new Point(119, 99);
            MaNV_ComboBox.Name = "MaNV_ComboBox";
            MaNV_ComboBox.Size = new Size(206, 28);
            MaNV_ComboBox.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 135);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 20;
            label8.Text = "Mã Trả:";
            // 
            // NgayMuon_Date
            // 
            NgayMuon_Date.Checked = false;
            NgayMuon_Date.Location = new Point(452, 29);
            NgayMuon_Date.Name = "NgayMuon_Date";
            NgayMuon_Date.Size = new Size(255, 27);
            NgayMuon_Date.TabIndex = 18;
            // 
            // MaXL_Textbox
            // 
            MaXL_Textbox.Location = new Point(119, 31);
            MaXL_Textbox.Name = "MaXL_Textbox";
            MaXL_Textbox.Size = new Size(206, 27);
            MaXL_Textbox.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 135);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 12;
            label4.Text = "Hình Thức Xử Lý:";
            // 
            // Thoat_Btn
            // 
            Thoat_Btn.Location = new Point(370, 25);
            Thoat_Btn.Name = "Thoat_Btn";
            Thoat_Btn.Size = new Size(94, 29);
            Thoat_Btn.TabIndex = 3;
            Thoat_Btn.Text = "Thoát";
            Thoat_Btn.UseVisualStyleBackColor = true;
            Thoat_Btn.Click += Thoat_Btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(292, 35);
            label6.Name = "label6";
            label6.Size = new Size(184, 35);
            label6.TabIndex = 25;
            label6.Text = "Xử Lý Vi Phạm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 36);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 11;
            label3.Text = "Ngày Mượn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 32);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 10;
            label2.Text = "Mã Xử Lý:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 66);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 9;
            label1.Text = "Mã Độc Giả:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 102);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 8;
            label9.Text = "Mã Nhân Viên:";
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(matra_combobox);
            groupBox3.Controls.Add(MaDocGia_Combobox);
            groupBox3.Controls.Add(LyDoVP_Textbox);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(MaNV_ComboBox);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(NgayMuon_Date);
            groupBox3.Controls.Add(MaXL_Textbox);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(12, 73);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(744, 186);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hoá Đơn";
            // 
            // matra_combobox
            // 
            matra_combobox.FormattingEnabled = true;
            matra_combobox.Items.AddRange(new object[] { "1" });
            matra_combobox.Location = new Point(119, 132);
            matra_combobox.Name = "matra_combobox";
            matra_combobox.Size = new Size(206, 28);
            matra_combobox.TabIndex = 27;
            // 
            // MaDocGia_Combobox
            // 
            MaDocGia_Combobox.FormattingEnabled = true;
            MaDocGia_Combobox.Items.AddRange(new object[] { "1" });
            MaDocGia_Combobox.Location = new Point(119, 65);
            MaDocGia_Combobox.Name = "MaDocGia_Combobox";
            MaDocGia_Combobox.Size = new Size(206, 28);
            MaDocGia_Combobox.TabIndex = 26;
            // 
            // LyDoVP_Textbox
            // 
            LyDoVP_Textbox.Location = new Point(452, 65);
            LyDoVP_Textbox.Multiline = true;
            LyDoVP_Textbox.Name = "LyDoVP_Textbox";
            LyDoVP_Textbox.Size = new Size(255, 53);
            LyDoVP_Textbox.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(331, 67);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 24;
            label5.Text = "Lý Do Vi Phạm:";
            // 
            // trảSáchToolStripMenuItem
            // 
            trảSáchToolStripMenuItem.Name = "trảSáchToolStripMenuItem";
            trảSáchToolStripMenuItem.Size = new Size(78, 24);
            trảSáchToolStripMenuItem.Text = "Trả Sách";
            trảSáchToolStripMenuItem.Click += trảSáchToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(Xóa_btn);
            groupBox1.Controls.Add(Thoat_Btn);
            groupBox1.Controls.Add(Sua_Btn);
            groupBox1.Controls.Add(Them_Btn);
            groupBox1.Location = new Point(12, 252);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(744, 80);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { trảSáchToolStripMenuItem, mượnSáchToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(768, 28);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // mượnSáchToolStripMenuItem
            // 
            mượnSáchToolStripMenuItem.Name = "mượnSáchToolStripMenuItem";
            mượnSáchToolStripMenuItem.Size = new Size(97, 24);
            mượnSáchToolStripMenuItem.Text = "Mượn Sách";
            mượnSáchToolStripMenuItem.Click += mượnSáchToolStripMenuItem_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Đã xử lý" });
            comboBox1.Location = new Point(455, 132);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 28);
            comboBox1.TabIndex = 28;
            // 
            // Xử_Lý_Vi_Phạm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(768, 556);
            Controls.Add(groupBox2);
            Controls.Add(label6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Xử_Lý_Vi_Phạm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xử Lý Vi Phạm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Xóa_btn;
        private Button Sua_Btn;
        private Button Them_Btn;
        private GroupBox groupBox2;
        private Button TimKiemTen_Btn;
        private TextBox TimKiemTen_Texbox;
        private Label label7;
        private DataGridView dataGridView1;
        private ComboBox MaNV_ComboBox;
        private Label label8;
        private DateTimePicker NgayMuon_Date;
        private TextBox MaXL_Textbox;
        private Label label4;
        private Button Thoat_Btn;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private GroupBox groupBox3;
        private ToolStripMenuItem trảSáchToolStripMenuItem;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mượnSáchToolStripMenuItem;
        private ComboBox MaDocGia_Combobox;
        private TextBox LyDoVP_Textbox;
        private Label label5;
        private ComboBox matra_combobox;
        private ComboBox comboBox1;
    }
}