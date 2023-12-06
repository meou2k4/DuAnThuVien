namespace NhomLatDat
{
    partial class Đăng_Nhập
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Đăng_Nhập));
            groupBox2 = new GroupBox();
            QuenMatKhau = new Button();
            Thoat_Btn = new Button();
            DoiMatKhau_Btn = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            MatKhauCu_Texbox = new TextBox();
            label10 = new Label();
            MatKhauMoi_Texbox = new TextBox();
            label2 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(QuenMatKhau);
            groupBox2.Controls.Add(Thoat_Btn);
            groupBox2.Controls.Add(DoiMatKhau_Btn);
            groupBox2.Location = new Point(12, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 77);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sử Dụng Chức Năng";
            // 
            // QuenMatKhau
            // 
            QuenMatKhau.Location = new Point(166, 26);
            QuenMatKhau.Name = "QuenMatKhau";
            QuenMatKhau.Size = new Size(131, 39);
            QuenMatKhau.TabIndex = 6;
            QuenMatKhau.Text = "Quên Mật Khẩu";
            QuenMatKhau.UseVisualStyleBackColor = true;
            QuenMatKhau.Click += QuenMatKhau_Click;
            // 
            // Thoat_Btn
            // 
            Thoat_Btn.Location = new Point(329, 26);
            Thoat_Btn.Name = "Thoat_Btn";
            Thoat_Btn.Size = new Size(131, 39);
            Thoat_Btn.TabIndex = 5;
            Thoat_Btn.Text = "Thoát";
            Thoat_Btn.UseVisualStyleBackColor = true;
            Thoat_Btn.Click += Thoat_Btn_Click;
            // 
            // DoiMatKhau_Btn
            // 
            DoiMatKhau_Btn.Location = new Point(6, 26);
            DoiMatKhau_Btn.Name = "DoiMatKhau_Btn";
            DoiMatKhau_Btn.Size = new Size(131, 39);
            DoiMatKhau_Btn.TabIndex = 3;
            DoiMatKhau_Btn.Text = "Đăng Nhập";
            DoiMatKhau_Btn.UseVisualStyleBackColor = true;
            DoiMatKhau_Btn.Click += DoiMatKhau_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(162, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 35);
            label1.TabIndex = 14;
            label1.Text = "Đăng Nhập";
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(MatKhauCu_Texbox);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(MatKhauMoi_Texbox);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(466, 141);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Thông Tin";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(98, 91);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 24);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // MatKhauCu_Texbox
            // 
            MatKhauCu_Texbox.BorderStyle = BorderStyle.FixedSingle;
            MatKhauCu_Texbox.Location = new Point(99, 25);
            MatKhauCu_Texbox.Name = "MatKhauCu_Texbox";
            MatKhauCu_Texbox.Size = new Size(261, 27);
            MatKhauCu_Texbox.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 27);
            label10.Name = "label10";
            label10.Size = new Size(76, 20);
            label10.TabIndex = 17;
            label10.Text = "Tài Khoản:";
            // 
            // MatKhauMoi_Texbox
            // 
            MatKhauMoi_Texbox.BorderStyle = BorderStyle.FixedSingle;
            MatKhauMoi_Texbox.Location = new Point(98, 58);
            MatKhauMoi_Texbox.Name = "MatKhauMoi_Texbox";
            MatKhauMoi_Texbox.Size = new Size(261, 27);
            MatKhauMoi_Texbox.TabIndex = 6;
            MatKhauMoi_Texbox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 60);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 0;
            label2.Text = "Mật Khẩu:";
            // 
            // Đăng_Nhập
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(490, 256);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Đăng_Nhập";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng_Nhập";
            Load += Đăng_Nhập_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button Thoat_Btn;
        private Button DoiMatKhau_Btn;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox MatKhauCu_Texbox;
        private Label label10;
        private TextBox MatKhauMoi_Texbox;
        private Label label2;
        private CheckBox checkBox1;
        private Button QuenMatKhau;
    }
}