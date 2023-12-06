namespace NhomLatDat
{
    partial class Quản_Lý_Độc_Giả
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quản_Lý_Độc_Giả));
            label1 = new Label();
            groupBox3 = new GroupBox();
            TimKiemTen_Btn = new Button();
            dataGridView1 = new DataGridView();
            TimKiemTen_Texbox = new TextBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            Thoat_Btn = new Button();
            Clear_Btn = new Button();
            Sua_Btn = new Button();
            Xoa_Btn = new Button();
            Them_Btn = new Button();
            groupBox1 = new GroupBox();
            MaNv_ComboBox = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            DiaChi_Text = new TextBox();
            label11 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            NgaySinh_DTP = new DateTimePicker();
            Nu_Radio = new RadioButton();
            Nam_Radio = new RadioButton();
            Email_TexBox = new TextBox();
            SDT_TextBox = new TextBox();
            CCCD_TextBox = new TextBox();
            HovaTen_Texbox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(275, 18);
            label1.Name = "label1";
            label1.Size = new Size(206, 35);
            label1.TabIndex = 7;
            label1.Text = "Quản Lý Độc Giả";
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(TimKiemTen_Btn);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Controls.Add(TimKiemTen_Texbox);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(12, 447);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 246);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ Liệu";
            groupBox3.Enter += groupBox3_Enter;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(764, 171);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // TimKiemTen_Texbox
            // 
            TimKiemTen_Texbox.Location = new Point(87, 16);
            TimKiemTen_Texbox.Name = "TimKiemTen_Texbox";
            TimKiemTen_Texbox.PlaceholderText = "Nhập Tên Muốn Tìm Kiếm";
            TimKiemTen_Texbox.Size = new Size(206, 27);
            TimKiemTen_Texbox.TabIndex = 15;
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
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(Thoat_Btn);
            groupBox2.Controls.Add(Clear_Btn);
            groupBox2.Controls.Add(Sua_Btn);
            groupBox2.Controls.Add(Xoa_Btn);
            groupBox2.Controls.Add(Them_Btn);
            groupBox2.Location = new Point(553, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(235, 385);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sử Dụng Chức Năng";
            // 
            // Thoat_Btn
            // 
            Thoat_Btn.Location = new Point(49, 226);
            Thoat_Btn.Name = "Thoat_Btn";
            Thoat_Btn.Size = new Size(131, 39);
            Thoat_Btn.TabIndex = 5;
            Thoat_Btn.Text = "Thoát";
            Thoat_Btn.UseVisualStyleBackColor = true;
            Thoat_Btn.Click += Thoat_Btn_Click;
            // 
            // Clear_Btn
            // 
            Clear_Btn.Location = new Point(49, 181);
            Clear_Btn.Name = "Clear_Btn";
            Clear_Btn.Size = new Size(131, 39);
            Clear_Btn.TabIndex = 3;
            Clear_Btn.Text = "Clear";
            Clear_Btn.UseVisualStyleBackColor = true;
            Clear_Btn.Click += Clear_Btn_Click;
            // 
            // Sua_Btn
            // 
            Sua_Btn.Location = new Point(49, 128);
            Sua_Btn.Name = "Sua_Btn";
            Sua_Btn.Size = new Size(131, 39);
            Sua_Btn.TabIndex = 2;
            Sua_Btn.Text = "Sửa";
            Sua_Btn.UseVisualStyleBackColor = true;
            Sua_Btn.Click += Sua_Btn_Click;
            // 
            // Xoa_Btn
            // 
            Xoa_Btn.Location = new Point(49, 80);
            Xoa_Btn.Name = "Xoa_Btn";
            Xoa_Btn.Size = new Size(131, 39);
            Xoa_Btn.TabIndex = 1;
            Xoa_Btn.Text = "Xoá";
            Xoa_Btn.UseVisualStyleBackColor = true;
            Xoa_Btn.Click += Xoa_Btn_Click;
            // 
            // Them_Btn
            // 
            Them_Btn.Location = new Point(49, 32);
            Them_Btn.Name = "Them_Btn";
            Them_Btn.Size = new Size(131, 39);
            Them_Btn.TabIndex = 0;
            Them_Btn.Text = "Thêm";
            Them_Btn.UseVisualStyleBackColor = true;
            Them_Btn.Click += Them_Btn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MaNv_ComboBox);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(DiaChi_Text);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(NgaySinh_DTP);
            groupBox1.Controls.Add(Nu_Radio);
            groupBox1.Controls.Add(Nam_Radio);
            groupBox1.Controls.Add(Email_TexBox);
            groupBox1.Controls.Add(SDT_TextBox);
            groupBox1.Controls.Add(CCCD_TextBox);
            groupBox1.Controls.Add(HovaTen_Texbox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(535, 385);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Thông Tin";
            // 
            // MaNv_ComboBox
            // 
            MaNv_ComboBox.FormattingEnabled = true;
            MaNv_ComboBox.Items.AddRange(new object[] { "1" });
            MaNv_ComboBox.Location = new Point(128, 277);
            MaNv_ComboBox.Name = "MaNv_ComboBox";
            MaNv_ComboBox.Size = new Size(394, 28);
            MaNv_ComboBox.TabIndex = 25;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(128, 346);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(394, 27);
            dateTimePicker2.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 351);
            label13.Name = "label13";
            label13.Size = new Size(106, 20);
            label13.TabIndex = 23;
            label13.Text = "Ngày Hết Hạn:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 280);
            label12.Name = "label12";
            label12.Size = new Size(105, 20);
            label12.TabIndex = 21;
            label12.Text = "Mã Nhân Viên:";
            // 
            // DiaChi_Text
            // 
            DiaChi_Text.BorderStyle = BorderStyle.FixedSingle;
            DiaChi_Text.Location = new Point(128, 243);
            DiaChi_Text.Name = "DiaChi_Text";
            DiaChi_Text.Size = new Size(394, 27);
            DiaChi_Text.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 247);
            label11.Name = "label11";
            label11.Size = new Size(60, 20);
            label11.TabIndex = 19;
            label11.Text = "Địa Chỉ:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(128, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 27);
            textBox1.TabIndex = 18;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 32);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 17;
            label10.Text = "Mã Độc Giả:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(128, 313);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(394, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 318);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 15;
            label9.Text = "Ngày Cấp:";
            // 
            // NgaySinh_DTP
            // 
            NgaySinh_DTP.Location = new Point(128, 118);
            NgaySinh_DTP.Name = "NgaySinh_DTP";
            NgaySinh_DTP.Size = new Size(394, 27);
            NgaySinh_DTP.TabIndex = 14;
            // 
            // Nu_Radio
            // 
            Nu_Radio.AutoSize = true;
            Nu_Radio.Location = new Point(216, 91);
            Nu_Radio.Name = "Nu_Radio";
            Nu_Radio.Size = new Size(50, 24);
            Nu_Radio.TabIndex = 13;
            Nu_Radio.TabStop = true;
            Nu_Radio.Text = "Nữ";
            Nu_Radio.UseVisualStyleBackColor = true;
            // 
            // Nam_Radio
            // 
            Nam_Radio.AutoSize = true;
            Nam_Radio.Location = new Point(128, 91);
            Nam_Radio.Name = "Nam_Radio";
            Nam_Radio.Size = new Size(62, 24);
            Nam_Radio.TabIndex = 12;
            Nam_Radio.TabStop = true;
            Nam_Radio.Text = "Nam";
            Nam_Radio.UseVisualStyleBackColor = true;
            // 
            // Email_TexBox
            // 
            Email_TexBox.BorderStyle = BorderStyle.FixedSingle;
            Email_TexBox.Location = new Point(128, 210);
            Email_TexBox.Name = "Email_TexBox";
            Email_TexBox.Size = new Size(394, 27);
            Email_TexBox.TabIndex = 11;
            // 
            // SDT_TextBox
            // 
            SDT_TextBox.BorderStyle = BorderStyle.FixedSingle;
            SDT_TextBox.Location = new Point(128, 179);
            SDT_TextBox.Name = "SDT_TextBox";
            SDT_TextBox.Size = new Size(394, 27);
            SDT_TextBox.TabIndex = 10;
            SDT_TextBox.KeyPress += SDT_TextBox_KeyPress;
            // 
            // CCCD_TextBox
            // 
            CCCD_TextBox.BorderStyle = BorderStyle.FixedSingle;
            CCCD_TextBox.Location = new Point(128, 148);
            CCCD_TextBox.Name = "CCCD_TextBox";
            CCCD_TextBox.Size = new Size(394, 27);
            CCCD_TextBox.TabIndex = 9;
            CCCD_TextBox.KeyPress += CCCD_TextBox_KeyPress;
            // 
            // HovaTen_Texbox
            // 
            HovaTen_Texbox.BorderStyle = BorderStyle.FixedSingle;
            HovaTen_Texbox.Location = new Point(128, 58);
            HovaTen_Texbox.Name = "HovaTen_Texbox";
            HovaTen_Texbox.Size = new Size(394, 27);
            HovaTen_Texbox.TabIndex = 6;
            HovaTen_Texbox.KeyPress += HovaTen_Texbox_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 214);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 5;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 183);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 4;
            label6.Text = "SĐT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 154);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 3;
            label5.Text = "Số CCCD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 125);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 2;
            label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 95);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 1;
            label3.Text = "Giới Tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 65);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 0;
            label2.Text = "Họ Và Tên:";
            // 
            // Quản_Lý_Độc_Giả
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 685);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Quản_Lý_Độc_Giả";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Độc Giả";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox3;
        private Button TimKiemTen_Btn;
        private DataGridView dataGridView1;
        private TextBox TimKiemTen_Texbox;
        private Label label8;
        private GroupBox groupBox2;
        private Button Sua_Btn;
        private Button Xoa_Btn;
        private Button Them_Btn;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private DateTimePicker NgaySinh_DTP;
        private RadioButton Nu_Radio;
        private RadioButton Nam_Radio;
        private TextBox Email_TexBox;
        private TextBox SDT_TextBox;
        private TextBox CCCD_TextBox;
        private TextBox HovaTen_Texbox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label10;
        private Button Thoat_Btn;
        private Button Clear_Btn;
        private DateTimePicker dateTimePicker2;
        private Label label13;
        private Label label12;
        private TextBox DiaChi_Text;
        private Label label11;
        private ComboBox MaNv_ComboBox;
    }
}