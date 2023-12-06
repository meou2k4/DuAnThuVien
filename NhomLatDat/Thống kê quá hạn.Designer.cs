namespace NhomLatDat
{
    partial class Thống_kê_quá_hạn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thống_kê_quá_hạn));
            txtsoluong = new Label();
            label2 = new Label();
            button1 = new Button();
            view = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)view).BeginInit();
            SuspendLayout();
            // 
            // txtsoluong
            // 
            txtsoluong.AutoSize = true;
            txtsoluong.Location = new Point(105, 362);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(50, 20);
            txtsoluong.TabIndex = 11;
            txtsoluong.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 362);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 10;
            label2.Text = "Số lượng:";
            // 
            // button1
            // 
            button1.Location = new Point(616, 397);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // view
            // 
            view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            view.Location = new Point(27, 25);
            view.Name = "view";
            view.RowHeadersWidth = 51;
            view.RowTemplate.Height = 29;
            view.Size = new Size(747, 318);
            view.TabIndex = 6;
            view.CellClick += view_CellClick;
            // 
            // Thống_kê_quá_hạn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(txtsoluong);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(view);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Thống_kê_quá_hạn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê Quá Hạn";
            Load += Thống_kê_quá_hạn_Load;
            ((System.ComponentModel.ISupportInitialize)view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtsoluong;
        private Label label2;
        private Button button1;
        private DataGridView view;
    }
}