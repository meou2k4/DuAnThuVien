namespace NhomLatDat
{
    partial class Quản_Lý_Nhà_Xuất_Bản
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quản_Lý_Nhà_Xuất_Bản));
            label1 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            Thoat_Btn = new Button();
            Sua_Btn = new Button();
            Xoa_Btn = new Button();
            Them_Btn = new Button();
            groupBox1 = new GroupBox();
            MaNXB_Texbox = new TextBox();
            label3 = new Label();
            GhiChu_TexBox = new TextBox();
            NhaXB_Texbox = new TextBox();
            label7 = new Label();
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
            label1.Location = new Point(183, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 35);
            label1.TabIndex = 24;
            label1.Text = "Quản Lý Nhà Xuất Bản";
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(31, 270);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(567, 223);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ Liệu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(545, 171);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(Thoat_Btn);
            groupBox2.Controls.Add(Sua_Btn);
            groupBox2.Controls.Add(Xoa_Btn);
            groupBox2.Controls.Add(Them_Btn);
            groupBox2.Location = new Point(31, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(567, 99);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sử Dụng Chức Năng";
            // 
            // Thoat_Btn
            // 
            Thoat_Btn.Location = new Point(426, 34);
            Thoat_Btn.Name = "Thoat_Btn";
            Thoat_Btn.Size = new Size(131, 39);
            Thoat_Btn.TabIndex = 13;
            Thoat_Btn.Text = "Thoát";
            Thoat_Btn.UseVisualStyleBackColor = true;
            Thoat_Btn.Click += Thoat_Btn_Click;
            // 
            // Sua_Btn
            // 
            Sua_Btn.Location = new Point(152, 34);
            Sua_Btn.Name = "Sua_Btn";
            Sua_Btn.Size = new Size(131, 39);
            Sua_Btn.TabIndex = 2;
            Sua_Btn.Text = "Sửa";
            Sua_Btn.UseVisualStyleBackColor = true;
            Sua_Btn.Click += Sua_Btn_Click;
            // 
            // Xoa_Btn
            // 
            Xoa_Btn.Location = new Point(289, 34);
            Xoa_Btn.Name = "Xoa_Btn";
            Xoa_Btn.Size = new Size(131, 39);
            Xoa_Btn.TabIndex = 1;
            Xoa_Btn.Text = "Xoá";
            Xoa_Btn.UseVisualStyleBackColor = true;
            Xoa_Btn.Click += Xoa_Btn_Click;
            // 
            // Them_Btn
            // 
            Them_Btn.Location = new Point(15, 34);
            Them_Btn.Name = "Them_Btn";
            Them_Btn.Size = new Size(131, 39);
            Them_Btn.TabIndex = 0;
            Them_Btn.Text = "Thêm";
            Them_Btn.UseVisualStyleBackColor = true;
            Them_Btn.Click += Them_Btn_Click;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(MaNXB_Texbox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(GhiChu_TexBox);
            groupBox1.Controls.Add(NhaXB_Texbox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(31, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 143);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Thông Tin";
            // 
            // MaNXB_Texbox
            // 
            MaNXB_Texbox.BorderStyle = BorderStyle.FixedSingle;
            MaNXB_Texbox.Location = new Point(139, 21);
            MaNXB_Texbox.Name = "MaNXB_Texbox";
            MaNXB_Texbox.Size = new Size(418, 27);
            MaNXB_Texbox.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 28);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 12;
            label3.Text = "Mã Nhà Xuất Bản:";
            // 
            // GhiChu_TexBox
            // 
            GhiChu_TexBox.BorderStyle = BorderStyle.FixedSingle;
            GhiChu_TexBox.Location = new Point(139, 90);
            GhiChu_TexBox.Name = "GhiChu_TexBox";
            GhiChu_TexBox.Size = new Size(418, 27);
            GhiChu_TexBox.TabIndex = 11;
            // 
            // NhaXB_Texbox
            // 
            NhaXB_Texbox.BorderStyle = BorderStyle.FixedSingle;
            NhaXB_Texbox.Location = new Point(139, 55);
            NhaXB_Texbox.Name = "NhaXB_Texbox";
            NhaXB_Texbox.Size = new Size(418, 27);
            NhaXB_Texbox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 92);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 5;
            label7.Text = "Ghi Chú:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 61);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 0;
            label2.Text = "Nhà Xuất Bản:";
            // 
            // Quản_Lý_Nhà_Xuất_Bản
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(628, 489);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Quản_Lý_Nhà_Xuất_Bản";
            Text = "Quản Lý Nhà Xuất Bản";
            groupBox3.ResumeLayout(false);
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
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button Thoat_Btn;
        private Button Sua_Btn;
        private Button Xoa_Btn;
        private Button Them_Btn;
        private GroupBox groupBox1;
        private TextBox MaNXB_Texbox;
        private Label label3;
        private TextBox GhiChu_TexBox;
        private TextBox NhaXB_Texbox;
        private Label label7;
        private Label label2;
    }
}