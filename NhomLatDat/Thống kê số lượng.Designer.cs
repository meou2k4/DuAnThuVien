namespace NhomLatDat
{
    partial class Thống_kê_số_lượng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thống_kê_số_lượng));
            view = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            txttongsach = new Label();
            label2 = new Label();
            txtsoluong = new Label();
            ((System.ComponentModel.ISupportInitialize)view).BeginInit();
            SuspendLayout();
            // 
            // view
            // 
            view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            view.Location = new Point(27, 24);
            view.Name = "view";
            view.RowHeadersWidth = 51;
            view.RowTemplate.Height = 29;
            view.Size = new Size(747, 318);
            view.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(616, 396);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 360);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 2;
            label1.Text = "Tổng số sách:";
            // 
            // txttongsach
            // 
            txttongsach.AutoSize = true;
            txttongsach.Location = new Point(131, 360);
            txttongsach.Name = "txttongsach";
            txttongsach.Size = new Size(50, 20);
            txttongsach.TabIndex = 3;
            txttongsach.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 360);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 4;
            label2.Text = "Số lượng:";
            // 
            // txtsoluong
            // 
            txtsoluong.AutoSize = true;
            txtsoluong.Location = new Point(326, 360);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(50, 20);
            txtsoluong.TabIndex = 5;
            txtsoluong.Text = "label3";
            // 
            // Thống_kê_số_lượng
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(txtsoluong);
            Controls.Add(label2);
            Controls.Add(txttongsach);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(view);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Thống_kê_số_lượng";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê Số Lượng";
            ((System.ComponentModel.ISupportInitialize)view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView view;
        private Button button1;
        private Label label1;
        private Label txttongsach;
        private Label label2;
        private Label txtsoluong;
    }
}