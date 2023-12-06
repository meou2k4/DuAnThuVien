namespace NhomLatDat
{
    partial class Quản_Lý_Sách
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quản_Lý_Sách));
            label1 = new Label();
            groupBox3 = new GroupBox();
            TimKiemTen_Btn = new Button();
            view = new DataGridView();
            TimKiemTen_Texbox = new TextBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            lblid = new Label();
            TacGia_ComboBox = new ComboBox();
            TheLoai_ComboBox = new ComboBox();
            NgonNgu_ComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            SoTrang_TexBox = new TextBox();
            label9 = new Label();
            SoLuong_TexBox = new TextBox();
            label7 = new Label();
            cmbNXB = new ComboBox();
            NgayCapNhat_Date = new DateTimePicker();
            label13 = new Label();
            TrangThai_Textbox = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            NgayXuatBan_Date = new DateTimePicker();
            TenSach_Texbox = new TextBox();
            label6 = new Label();
            label2 = new Label();
            groupBox4 = new GroupBox();
            btnxoct = new Button();
            btnSuaCT = new Button();
            btnthemCT = new Button();
            groupBox5 = new GroupBox();
            Clear_Btn = new Button();
            Thoat_Btn = new Button();
            Them_Btn = new Button();
            Sua_Btn = new Button();
            Xoa_Btn = new Button();
            groupBox6 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)view).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(506, 16);
            label1.Name = "label1";
            label1.Size = new Size(170, 35);
            label1.TabIndex = 7;
            label1.Text = "Quản Lý Sách";
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(TimKiemTen_Btn);
            groupBox3.Controls.Add(view);
            groupBox3.Controls.Add(TimKiemTen_Texbox);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(76, 455);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1149, 252);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ Liệu";
            // 
            // TimKiemTen_Btn
            // 
            TimKiemTen_Btn.Location = new Point(299, 15);
            TimKiemTen_Btn.Name = "TimKiemTen_Btn";
            TimKiemTen_Btn.Size = new Size(91, 26);
            TimKiemTen_Btn.TabIndex = 4;
            TimKiemTen_Btn.Text = "Tìm Kiếm";
            TimKiemTen_Btn.UseVisualStyleBackColor = true;
            TimKiemTen_Btn.Click += TimKiemTen_Btn_Click;
            // 
            // view
            // 
            view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            view.Location = new Point(6, 49);
            view.Name = "view";
            view.RowHeadersWidth = 51;
            view.RowTemplate.Height = 29;
            view.Size = new Size(1137, 177);
            view.TabIndex = 16;
            view.CellClick += view_CellClick;
            // 
            // TimKiemTen_Texbox
            // 
            TimKiemTen_Texbox.Location = new Point(87, 16);
            TimKiemTen_Texbox.Name = "TimKiemTen_Texbox";
            TimKiemTen_Texbox.PlaceholderText = "Nhập Tên Muốn Tìm Kiếm";
            TimKiemTen_Texbox.Size = new Size(206, 27);
            TimKiemTen_Texbox.TabIndex = 15;
            TimKiemTen_Texbox.TextChanged += TimKiemTen_Texbox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 20);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 15;
            label8.Text = "Tìm Kiếm:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblid);
            groupBox2.Controls.Add(TacGia_ComboBox);
            groupBox2.Controls.Add(TheLoai_ComboBox);
            groupBox2.Controls.Add(NgonNgu_ComboBox);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(456, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(374, 191);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Sách:";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(38, 28);
            lblid.Name = "lblid";
            lblid.Size = new Size(68, 20);
            lblid.TabIndex = 21;
            lblid.Text = "Mã Sách:";
            lblid.Visible = false;
            // 
            // TacGia_ComboBox
            // 
            TacGia_ComboBox.FormattingEnabled = true;
            TacGia_ComboBox.ImeMode = ImeMode.NoControl;
            TacGia_ComboBox.IntegralHeight = false;
            TacGia_ComboBox.Items.AddRange(new object[] { "1" });
            TacGia_ComboBox.Location = new Point(146, 48);
            TacGia_ComboBox.Name = "TacGia_ComboBox";
            TacGia_ComboBox.Size = new Size(192, 28);
            TacGia_ComboBox.TabIndex = 16;
            // 
            // TheLoai_ComboBox
            // 
            TheLoai_ComboBox.FormattingEnabled = true;
            TheLoai_ComboBox.IntegralHeight = false;
            TheLoai_ComboBox.Items.AddRange(new object[] { "1" });
            TheLoai_ComboBox.Location = new Point(146, 90);
            TheLoai_ComboBox.Name = "TheLoai_ComboBox";
            TheLoai_ComboBox.Size = new Size(192, 28);
            TheLoai_ComboBox.TabIndex = 17;
            // 
            // NgonNgu_ComboBox
            // 
            NgonNgu_ComboBox.FormattingEnabled = true;
            NgonNgu_ComboBox.Items.AddRange(new object[] { "1" });
            NgonNgu_ComboBox.Location = new Point(146, 138);
            NgonNgu_ComboBox.Name = "NgonNgu_ComboBox";
            NgonNgu_ComboBox.Size = new Size(192, 28);
            NgonNgu_ComboBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 51);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã Tác Giả:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 93);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 2;
            label4.Text = "Mã Thể Loại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 141);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 3;
            label5.Text = "Mã Ngôn Ngữ:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(SoTrang_TexBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(SoLuong_TexBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbNXB);
            groupBox1.Controls.Add(NgayCapNhat_Date);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(TrangThai_Textbox);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(NgayXuatBan_Date);
            groupBox1.Controls.Add(TenSach_Texbox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(76, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 293);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Thông Tin";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(152, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 35;
            // 
            // SoTrang_TexBox
            // 
            SoTrang_TexBox.BorderStyle = BorderStyle.FixedSingle;
            SoTrang_TexBox.Location = new Point(152, 220);
            SoTrang_TexBox.Name = "SoTrang_TexBox";
            SoTrang_TexBox.Size = new Size(204, 27);
            SoTrang_TexBox.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 222);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 33;
            label9.Text = "Số Trang:";
            // 
            // SoLuong_TexBox
            // 
            SoLuong_TexBox.BorderStyle = BorderStyle.FixedSingle;
            SoLuong_TexBox.Location = new Point(151, 187);
            SoLuong_TexBox.Name = "SoLuong_TexBox";
            SoLuong_TexBox.Size = new Size(205, 27);
            SoLuong_TexBox.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 189);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 31;
            label7.Text = "Số Lượng:";
            // 
            // cmbNXB
            // 
            cmbNXB.FormattingEnabled = true;
            cmbNXB.Items.AddRange(new object[] { "1" });
            cmbNXB.Location = new Point(152, 87);
            cmbNXB.Name = "cmbNXB";
            cmbNXB.Size = new Size(205, 28);
            cmbNXB.TabIndex = 30;
            // 
            // NgayCapNhat_Date
            // 
            NgayCapNhat_Date.Location = new Point(152, 154);
            NgayCapNhat_Date.Name = "NgayCapNhat_Date";
            NgayCapNhat_Date.Size = new Size(205, 27);
            NgayCapNhat_Date.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 159);
            label13.Name = "label13";
            label13.Size = new Size(113, 20);
            label13.TabIndex = 28;
            label13.Text = "Ngày Cập Nhật:";
            // 
            // TrangThai_Textbox
            // 
            TrangThai_Textbox.BorderStyle = BorderStyle.FixedSingle;
            TrangThai_Textbox.Location = new Point(151, 253);
            TrangThai_Textbox.Name = "TrangThai_Textbox";
            TrangThai_Textbox.Size = new Size(204, 27);
            TrangThai_Textbox.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 255);
            label12.Name = "label12";
            label12.Size = new Size(81, 20);
            label12.TabIndex = 24;
            label12.Text = "Trạng Thái:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 90);
            label11.Name = "label11";
            label11.Size = new Size(102, 20);
            label11.TabIndex = 22;
            label11.Text = "Nhà Xuất Bản:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 23);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 20;
            label10.Text = "Mã Sách:";
            // 
            // NgayXuatBan_Date
            // 
            NgayXuatBan_Date.Location = new Point(152, 121);
            NgayXuatBan_Date.Name = "NgayXuatBan_Date";
            NgayXuatBan_Date.Size = new Size(205, 27);
            NgayXuatBan_Date.TabIndex = 14;
            // 
            // TenSach_Texbox
            // 
            TenSach_Texbox.BorderStyle = BorderStyle.FixedSingle;
            TenSach_Texbox.Location = new Point(152, 54);
            TenSach_Texbox.Name = "TenSach_Texbox";
            TenSach_Texbox.Size = new Size(204, 27);
            TenSach_Texbox.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 126);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 4;
            label6.Text = "Ngày Xuất Bản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 56);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên Sách:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnxoct);
            groupBox4.Controls.Add(btnSuaCT);
            groupBox4.Controls.Add(btnthemCT);
            groupBox4.Location = new Point(456, 251);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(374, 96);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Nhập Thông Tin Sách:";
            // 
            // btnxoct
            // 
            btnxoct.Location = new Point(253, 41);
            btnxoct.Name = "btnxoct";
            btnxoct.Size = new Size(102, 42);
            btnxoct.TabIndex = 6;
            btnxoct.Text = "Xóa";
            btnxoct.UseVisualStyleBackColor = true;
            btnxoct.Click += btnxoct_Click;
            // 
            // btnSuaCT
            // 
            btnSuaCT.Location = new Point(133, 41);
            btnSuaCT.Name = "btnSuaCT";
            btnSuaCT.Size = new Size(102, 42);
            btnSuaCT.TabIndex = 5;
            btnSuaCT.Text = "Sửa";
            btnSuaCT.UseVisualStyleBackColor = true;
            btnSuaCT.Click += btnSuaCT_Click;
            // 
            // btnthemCT
            // 
            btnthemCT.Location = new Point(18, 41);
            btnthemCT.Name = "btnthemCT";
            btnthemCT.Size = new Size(102, 42);
            btnthemCT.TabIndex = 3;
            btnthemCT.Text = "Thêm";
            btnthemCT.UseVisualStyleBackColor = true;
            btnthemCT.Click += btnthemCT_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(Clear_Btn);
            groupBox5.Controls.Add(Thoat_Btn);
            groupBox5.Controls.Add(Them_Btn);
            groupBox5.Controls.Add(Sua_Btn);
            groupBox5.Controls.Add(Xoa_Btn);
            groupBox5.Location = new Point(76, 353);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(754, 96);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức Năng:";
            // 
            // Clear_Btn
            // 
            Clear_Btn.Location = new Point(584, 35);
            Clear_Btn.Name = "Clear_Btn";
            Clear_Btn.Size = new Size(131, 39);
            Clear_Btn.TabIndex = 13;
            Clear_Btn.Text = "Clear";
            Clear_Btn.UseVisualStyleBackColor = true;
            Clear_Btn.Click += Clear_Btn_Click;
            // 
            // Thoat_Btn
            // 
            Thoat_Btn.Location = new Point(447, 35);
            Thoat_Btn.Name = "Thoat_Btn";
            Thoat_Btn.Size = new Size(131, 39);
            Thoat_Btn.TabIndex = 14;
            Thoat_Btn.Text = "Thoát";
            Thoat_Btn.UseVisualStyleBackColor = true;
            Thoat_Btn.Click += Thoat_Btn_Click;
            // 
            // Them_Btn
            // 
            Them_Btn.Location = new Point(36, 35);
            Them_Btn.Name = "Them_Btn";
            Them_Btn.Size = new Size(131, 39);
            Them_Btn.TabIndex = 10;
            Them_Btn.Text = "Thêm";
            Them_Btn.UseVisualStyleBackColor = true;
            Them_Btn.Click += Them_Btn_Click;
            // 
            // Sua_Btn
            // 
            Sua_Btn.Location = new Point(173, 35);
            Sua_Btn.Name = "Sua_Btn";
            Sua_Btn.Size = new Size(131, 39);
            Sua_Btn.TabIndex = 12;
            Sua_Btn.Text = "Sửa";
            Sua_Btn.UseVisualStyleBackColor = true;
            Sua_Btn.Click += Sua_Btn_Click;
            // 
            // Xoa_Btn
            // 
            Xoa_Btn.Location = new Point(310, 35);
            Xoa_Btn.Name = "Xoa_Btn";
            Xoa_Btn.Size = new Size(131, 39);
            Xoa_Btn.TabIndex = 11;
            Xoa_Btn.Text = "Xoá";
            Xoa_Btn.UseVisualStyleBackColor = true;
            Xoa_Btn.Click += Xoa_Btn_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dataGridView1);
            groupBox6.Location = new Point(836, 54);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(389, 395);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Chi Tiết Sách:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(377, 366);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Quản_Lý_Sách
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1313, 710);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Quản_Lý_Sách";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sách";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)view).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox3;
        private Button TimKiemTen_Btn;
        private DataGridView view;
        private TextBox TimKiemTen_Texbox;
        private Label label8;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DateTimePicker NgayXuatBan_Date;
        private TextBox TenSach_Texbox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox NgonNgu_ComboBox;
        private ComboBox TacGia_ComboBox;
        private Label label10;
        private ComboBox TheLoai_ComboBox;
        private Label label11;
        private TextBox TrangThai_Textbox;
        private Label label12;
        private Label label13;
        private ComboBox cmbNXB;
        private DateTimePicker NgayCapNhat_Date;
        private TextBox SoTrang_TexBox;
        private Label label9;
        private TextBox SoLuong_TexBox;
        private Label label7;
        private ComboBox Masach_cmb;
        private TextBox textBox1;
        private GroupBox groupBox4;
        private Button btnSuaCT;
        private Button btnthemCT;
        private GroupBox groupBox5;
        private Button Clear_Btn;
        private Button Thoat_Btn;
        private Button Them_Btn;
        private Button Sua_Btn;
        private Button Xoa_Btn;
        private GroupBox groupBox6;
        private DataGridView dataGridView1;
        private Button btnxoct;
        private Label lblid;
    }
}