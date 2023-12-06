namespace NhomLatDat
{
    partial class Quên_mật_khẩu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quên_mật_khẩu));
            groupBox2 = new GroupBox();
            QuenMatKhau = new Button();
            Thoat_Btn = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            SDTtext = new TextBox();
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
            groupBox2.Location = new Point(21, 205);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 91);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sử Dụng Chức Năng";
            // 
            // QuenMatKhau
            // 
            QuenMatKhau.Location = new Point(83, 26);
            QuenMatKhau.Name = "QuenMatKhau";
            QuenMatKhau.Size = new Size(131, 39);
            QuenMatKhau.TabIndex = 6;
            QuenMatKhau.Text = "Quên Mật Khẩu";
            QuenMatKhau.UseVisualStyleBackColor = true;
            QuenMatKhau.Click += QuenMatKhau_Click;
            // 
            // Thoat_Btn
            // 
            Thoat_Btn.Location = new Point(246, 26);
            Thoat_Btn.Name = "Thoat_Btn";
            Thoat_Btn.Size = new Size(131, 39);
            Thoat_Btn.TabIndex = 5;
            Thoat_Btn.Text = "Thoát";
            Thoat_Btn.UseVisualStyleBackColor = true;
            Thoat_Btn.Click += Thoat_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(148, 9);
            label1.Name = "label1";
            label1.Size = new Size(198, 35);
            label1.TabIndex = 17;
            label1.Text = "Quên Mật Khẩu";
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(SDTtext);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(MatKhauMoi_Texbox);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(21, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(466, 178);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Thông Tin";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(162, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 27);
            textBox1.TabIndex = 20;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 93);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 19;
            label3.Text = "Nhập Lại Mật Khẩu:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(98, 128);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 24);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // SDTtext
            // 
            SDTtext.BorderStyle = BorderStyle.FixedSingle;
            SDTtext.Location = new Point(162, 25);
            SDTtext.Name = "SDTtext";
            SDTtext.Size = new Size(273, 27);
            SDTtext.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 27);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 17;
            label10.Text = "Số điện thoại:";
            // 
            // MatKhauMoi_Texbox
            // 
            MatKhauMoi_Texbox.BorderStyle = BorderStyle.FixedSingle;
            MatKhauMoi_Texbox.Location = new Point(161, 58);
            MatKhauMoi_Texbox.Name = "MatKhauMoi_Texbox";
            MatKhauMoi_Texbox.Size = new Size(273, 27);
            MatKhauMoi_Texbox.TabIndex = 6;
            MatKhauMoi_Texbox.UseSystemPasswordChar = true;
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
            // Quên_mật_khẩu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(506, 294);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Quên_mật_khẩu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên Mật Khẩu";
            Load += Quên_mật_khẩu_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button QuenMatKhau;
        private Button Thoat_Btn;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label3;
        private CheckBox checkBox1;
        private TextBox SDTtext;
        private Label label10;
        private TextBox MatKhauMoi_Texbox;
        private Label label2;
    }
}