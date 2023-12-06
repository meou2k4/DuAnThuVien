namespace NhomLatDat
{
    partial class Trả_Sách
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trả_Sách));
            mượnSáchToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            xửLýViPhạmToolStripMenuItem = new ToolStripMenuItem();
            label5 = new Label();
            groupBox6 = new GroupBox();
            view2 = new DataGridView();
            groupBox5 = new GroupBox();
            btnxoasach = new Button();
            btnthemsach = new Button();
            btnsuasach = new Button();
            groupBox4 = new GroupBox();
            MaSach_Combobox = new ComboBox();
            SoLuong_Textbox = new TextBox();
            label10 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            TimKiemTen_Btn = new Button();
            TimKiemTen_Texbox = new TextBox();
            label7 = new Label();
            view1 = new DataGridView();
            groupBox1 = new GroupBox();
            btnthoat = new Button();
            btnInPhieu = new Button();
            btnsach = new Button();
            btnthem = new Button();
            btnsua = new Button();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            MaDocGia_ComboBox = new ComboBox();
            NgayTraDate = new DateTimePicker();
            label6 = new Label();
            Manvcmb = new ComboBox();
            nhanVienServiceBindingSource = new BindingSource(components);
            label8 = new Label();
            HanTraDate = new DateTimePicker();
            NgayMuonDate = new DateTimePicker();
            IDPhieu_Textbox = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label9 = new Label();
            label11 = new Label();
            lblid = new Label();
            docGiaServiceBindingSource = new BindingSource(components);
            docGiaServiceBindingSource1 = new BindingSource(components);
            menuStrip1.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)view2).BeginInit();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)view1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nhanVienServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)docGiaServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)docGiaServiceBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // mượnSáchToolStripMenuItem
            // 
            mượnSáchToolStripMenuItem.AutoSize = false;
            mượnSáchToolStripMenuItem.Name = "mượnSáchToolStripMenuItem";
            mượnSáchToolStripMenuItem.Size = new Size(97, 24);
            mượnSáchToolStripMenuItem.Text = "Mượn Sách";
            mượnSáchToolStripMenuItem.Click += mượnSáchToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mượnSáchToolStripMenuItem, xửLýViPhạmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(825, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // xửLýViPhạmToolStripMenuItem
            // 
            xửLýViPhạmToolStripMenuItem.Name = "xửLýViPhạmToolStripMenuItem";
            xửLýViPhạmToolStripMenuItem.Size = new Size(116, 24);
            xửLýViPhạmToolStripMenuItem.Text = "Xử Lý Vi Phạm";
            xửLýViPhạmToolStripMenuItem.Click += xửLýViPhạmToolStripMenuItem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(319, 45);
            label5.Name = "label5";
            label5.Size = new Size(112, 35);
            label5.TabIndex = 10;
            label5.Text = "Trả Sách";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(view2);
            groupBox6.Location = new Point(569, 189);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(250, 237);
            groupBox6.TabIndex = 30;
            groupBox6.TabStop = false;
            groupBox6.Text = "Sách Trong Hóa Đơn";
            // 
            // view2
            // 
            view2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            view2.Location = new Point(6, 26);
            view2.Name = "view2";
            view2.RowHeadersWidth = 51;
            view2.RowTemplate.Height = 29;
            view2.Size = new Size(238, 205);
            view2.TabIndex = 1;
            view2.CellClick += view2_CellClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnxoasach);
            groupBox5.Controls.Add(btnthemsach);
            groupBox5.Controls.Add(btnsuasach);
            groupBox5.Location = new Point(569, 432);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(250, 125);
            groupBox5.TabIndex = 29;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thêm sách";
            // 
            // btnxoasach
            // 
            btnxoasach.Location = new Point(73, 70);
            btnxoasach.Name = "btnxoasach";
            btnxoasach.Size = new Size(94, 29);
            btnxoasach.TabIndex = 27;
            btnxoasach.Text = "Xóa";
            btnxoasach.UseVisualStyleBackColor = true;
            btnxoasach.Click += btnxoasach_Click;
            // 
            // btnthemsach
            // 
            btnthemsach.Location = new Point(6, 35);
            btnthemsach.Name = "btnthemsach";
            btnthemsach.Size = new Size(94, 29);
            btnthemsach.TabIndex = 25;
            btnthemsach.Text = "Thêm";
            btnthemsach.UseVisualStyleBackColor = true;
            btnthemsach.Click += btnthemsach_Click;
            // 
            // btnsuasach
            // 
            btnsuasach.Location = new Point(150, 35);
            btnsuasach.Name = "btnsuasach";
            btnsuasach.Size = new Size(94, 29);
            btnsuasach.TabIndex = 26;
            btnsuasach.Text = "Sửa";
            btnsuasach.UseVisualStyleBackColor = true;
            btnsuasach.Click += btnsuasach_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(MaSach_Combobox);
            groupBox4.Controls.Add(SoLuong_Textbox);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(569, 85);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(253, 98);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin sách";
            // 
            // MaSach_Combobox
            // 
            MaSach_Combobox.FormattingEnabled = true;
            MaSach_Combobox.Items.AddRange(new object[] { "1" });
            MaSach_Combobox.Location = new Point(82, 27);
            MaSach_Combobox.Name = "MaSach_Combobox";
            MaSach_Combobox.Size = new Size(164, 28);
            MaSach_Combobox.TabIndex = 2;
            // 
            // SoLuong_Textbox
            // 
            SoLuong_Textbox.Location = new Point(83, 61);
            SoLuong_Textbox.Name = "SoLuong_Textbox";
            SoLuong_Textbox.Size = new Size(164, 27);
            SoLuong_Textbox.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 64);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 24;
            label10.Text = "Số Lượng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 9;
            label1.Text = "Mã Sách:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TimKiemTen_Btn);
            groupBox2.Controls.Add(TimKiemTen_Texbox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(view1);
            groupBox2.Location = new Point(2, 328);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(561, 229);
            groupBox2.TabIndex = 26;
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
            // view1
            // 
            view1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            view1.Location = new Point(35, 59);
            view1.Name = "view1";
            view1.RowHeadersWidth = 51;
            view1.RowTemplate.Height = 29;
            view1.Size = new Size(514, 160);
            view1.TabIndex = 0;
            view1.CellClick += view1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnthoat);
            groupBox1.Controls.Add(btnInPhieu);
            groupBox1.Controls.Add(btnsach);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Location = new Point(2, 262);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(561, 60);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(435, 26);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(94, 29);
            btnthoat.TabIndex = 10;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnInPhieu
            // 
            btnInPhieu.Location = new Point(335, 26);
            btnInPhieu.Name = "btnInPhieu";
            btnInPhieu.Size = new Size(94, 29);
            btnInPhieu.TabIndex = 9;
            btnInPhieu.Text = "In Phiếu";
            btnInPhieu.UseVisualStyleBackColor = true;
            btnInPhieu.Click += btnInPhieu_Click;
            // 
            // btnsach
            // 
            btnsach.Location = new Point(235, 26);
            btnsach.Name = "btnsach";
            btnsach.Size = new Size(94, 29);
            btnsach.TabIndex = 8;
            btnsach.Text = "Xóa";
            btnsach.UseVisualStyleBackColor = true;
            btnsach.Click += btnsach_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(35, 26);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 6;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(135, 26);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 7;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(MaDocGia_ComboBox);
            groupBox3.Controls.Add(NgayTraDate);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(Manvcmb);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(HanTraDate);
            groupBox3.Controls.Add(NgayMuonDate);
            groupBox3.Controls.Add(IDPhieu_Textbox);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(2, 83);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(561, 173);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hoá Đơn";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(376, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 29;
            // 
            // MaDocGia_ComboBox
            // 
            MaDocGia_ComboBox.FormattingEnabled = true;
            MaDocGia_ComboBox.Location = new Point(119, 63);
            MaDocGia_ComboBox.Name = "MaDocGia_ComboBox";
            MaDocGia_ComboBox.Size = new Size(164, 28);
            MaDocGia_ComboBox.TabIndex = 28;
            // 
            // NgayTraDate
            // 
            NgayTraDate.Location = new Point(376, 59);
            NgayTraDate.Name = "NgayTraDate";
            NgayTraDate.Size = new Size(164, 27);
            NgayTraDate.TabIndex = 26;
            NgayTraDate.Value = new DateTime(2023, 12, 5, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(289, 64);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 27;
            label6.Text = "Ngày Trả:";
            // 
            // Manvcmb
            // 
            Manvcmb.DataSource = nhanVienServiceBindingSource;
            Manvcmb.DisplayMember = "Manv";
            Manvcmb.FormattingEnabled = true;
            Manvcmb.Location = new Point(119, 96);
            Manvcmb.Name = "Manvcmb";
            Manvcmb.Size = new Size(164, 28);
            Manvcmb.TabIndex = 25;
            // 
            // nhanVienServiceBindingSource
            // 
            nhanVienServiceBindingSource.DataSource = typeof(BUS.Service.NhanVienService);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 99);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 20;
            label8.Text = "Mã Nhân Viên:";
            // 
            // HanTraDate
            // 
            HanTraDate.Location = new Point(376, 27);
            HanTraDate.Name = "HanTraDate";
            HanTraDate.Size = new Size(164, 27);
            HanTraDate.TabIndex = 6;
            HanTraDate.Value = new DateTime(2023, 12, 5, 0, 0, 0, 0);
            // 
            // NgayMuonDate
            // 
            NgayMuonDate.Location = new Point(119, 132);
            NgayMuonDate.Name = "NgayMuonDate";
            NgayMuonDate.Size = new Size(164, 27);
            NgayMuonDate.TabIndex = 5;
            NgayMuonDate.Value = new DateTime(2023, 12, 5, 0, 0, 0, 0);
            // 
            // IDPhieu_Textbox
            // 
            IDPhieu_Textbox.Location = new Point(119, 31);
            IDPhieu_Textbox.Name = "IDPhieu_Textbox";
            IDPhieu_Textbox.Size = new Size(164, 27);
            IDPhieu_Textbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 96);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 13;
            label2.Text = "Trạng Thái:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 32);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 12;
            label4.Text = "Hạn Trả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 132);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 11;
            label3.Text = "Ngày Mượn:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 32);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 10;
            label9.Text = "Mã Phiếu:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 66);
            label11.Name = "label11";
            label11.Size = new Size(90, 20);
            label11.TabIndex = 8;
            label11.Text = "Mã Độc Giả:";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(572, 57);
            lblid.Name = "lblid";
            lblid.Size = new Size(0, 20);
            lblid.TabIndex = 31;
            lblid.Visible = false;
            // 
            // docGiaServiceBindingSource
            // 
            docGiaServiceBindingSource.DataSource = typeof(BUS.Service.DocGiaService);
            // 
            // docGiaServiceBindingSource1
            // 
            docGiaServiceBindingSource1.DataSource = typeof(BUS.Service.DocGiaService);
            // 
            // Trả_Sách
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(825, 562);
            Controls.Add(lblid);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(label5);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Trả_Sách";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trả Sách";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)view2).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)view1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nhanVienServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)docGiaServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)docGiaServiceBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem mượnSáchToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Label label5;
        private ToolStripMenuItem xửLýViPhạmToolStripMenuItem;
        private GroupBox groupBox6;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox groupBox5;
        private Button btnxoasach;
        private Button btnthemsach;
        private Button btnsuasach;
        private GroupBox groupBox4;
        private ComboBox MaSach_Combobox;
        private TextBox SoLuong_Textbox;
        private Label label10;
        private Label label1;
        private GroupBox groupBox2;
        private Button TimKiemTen_Btn;
        private TextBox TimKiemTen_Texbox;
        private Label label7;
        private DataGridView view1;
        private GroupBox groupBox1;
        private Button btnthoat;
        private Button btnInPhieu;
        private Button btnsach;
        private Button btnthem;
        private Button btnsua;
        private GroupBox groupBox3;
        private DateTimePicker NgayTraDate;
        private Label label6;
        private ComboBox Manvcmb;
        private Label label8;
        private DateTimePicker HanTraDate;
        private DateTimePicker NgayMuonDate;
        private TextBox IDPhieu_Textbox;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label11;
        private DataGridView view2;
        private Label lblid;
        private BindingSource nhanVienServiceBindingSource;
        private ComboBox MaDocGia_ComboBox;
        private BindingSource docGiaServiceBindingSource1;
        private BindingSource docGiaServiceBindingSource;
        private TextBox textBox1;
    }
}