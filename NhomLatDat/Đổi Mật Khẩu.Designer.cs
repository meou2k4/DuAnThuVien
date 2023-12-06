namespace NhomLatDat
{
    partial class Đổi_Mật_Khẩu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Đổi_Mật_Khẩu));
            MatKhauCu_Texbox = new TextBox();
            label10 = new Label();
            NhapLaiMatKhauMoi_TextBox = new TextBox();
            MatKhauMoi_Texbox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Thoat_Btn = new Button();
            DoiMatKhau_Btn = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // MatKhauCu_Texbox
            // 
            MatKhauCu_Texbox.BorderStyle = BorderStyle.FixedSingle;
            MatKhauCu_Texbox.Location = new Point(190, 25);
            MatKhauCu_Texbox.Name = "MatKhauCu_Texbox";
            MatKhauCu_Texbox.Size = new Size(261, 27);
            MatKhauCu_Texbox.TabIndex = 18;
            MatKhauCu_Texbox.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 27);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 17;
            label10.Text = "Mật Khẩu Cũ:";
            // 
            // NhapLaiMatKhauMoi_TextBox
            // 
            NhapLaiMatKhauMoi_TextBox.BorderStyle = BorderStyle.FixedSingle;
            NhapLaiMatKhauMoi_TextBox.Location = new Point(190, 94);
            NhapLaiMatKhauMoi_TextBox.Name = "NhapLaiMatKhauMoi_TextBox";
            NhapLaiMatKhauMoi_TextBox.Size = new Size(261, 27);
            NhapLaiMatKhauMoi_TextBox.TabIndex = 9;
            NhapLaiMatKhauMoi_TextBox.UseSystemPasswordChar = true;
            // 
            // MatKhauMoi_Texbox
            // 
            MatKhauMoi_Texbox.BorderStyle = BorderStyle.FixedSingle;
            MatKhauMoi_Texbox.Location = new Point(190, 58);
            MatKhauMoi_Texbox.Name = "MatKhauMoi_Texbox";
            MatKhauMoi_Texbox.Size = new Size(261, 27);
            MatKhauMoi_Texbox.TabIndex = 6;
            MatKhauMoi_Texbox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 96);
            label3.Name = "label3";
            label3.Size = new Size(168, 20);
            label3.TabIndex = 1;
            label3.Text = "Nhập Lại Mật Khẩu Mới:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 60);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 0;
            label2.Text = "Mật Khẩu Mới:";
            // 
            // Thoat_Btn
            // 
            Thoat_Btn.Location = new Point(299, 26);
            Thoat_Btn.Name = "Thoat_Btn";
            Thoat_Btn.Size = new Size(131, 39);
            Thoat_Btn.TabIndex = 5;
            Thoat_Btn.Text = "Thoát";
            Thoat_Btn.UseVisualStyleBackColor = true;
            Thoat_Btn.Click += Thoat_Btn_Click;
            // 
            // DoiMatKhau_Btn
            // 
            DoiMatKhau_Btn.Location = new Point(74, 26);
            DoiMatKhau_Btn.Name = "DoiMatKhau_Btn";
            DoiMatKhau_Btn.Size = new Size(131, 39);
            DoiMatKhau_Btn.TabIndex = 3;
            DoiMatKhau_Btn.Text = "Đổi Mật Khẩu";
            DoiMatKhau_Btn.UseVisualStyleBackColor = true;
            DoiMatKhau_Btn.Click += DoiMatKhau_Btn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Thoat_Btn);
            groupBox2.Controls.Add(DoiMatKhau_Btn);
            groupBox2.Location = new Point(12, 208);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(474, 77);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sử Dụng Chức Năng";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(157, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 35);
            label1.TabIndex = 11;
            label1.Text = "Đổi Mật Khẩu";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(MatKhauCu_Texbox);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(NhapLaiMatKhauMoi_TextBox);
            groupBox1.Controls.Add(MatKhauMoi_Texbox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(474, 155);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Thông Tin";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(190, 127);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 24);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Đổi_Mật_Khẩu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(497, 294);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Đổi_Mật_Khẩu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi Mật Khẩu";
            Load += Đổi_Mật_Khẩu_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox MatKhauCu_Texbox;
        private Label label10;
        private TextBox NhapLaiMatKhauMoi_TextBox;
        private TextBox MatKhauMoi_Texbox;
        private Label label3;
        private Label label2;
        private Button Thoat_Btn;
        private Button DoiMatKhau_Btn;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox1;
        private CheckBox checkBox1;
    }
}