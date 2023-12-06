namespace NhomLatDat
{
    partial class InPhieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InPhieu));
            xemtruoctxt = new RichTextBox();
            btnin = new Button();
            thoat = new Button();
            back = new Button();
            phieuintxt = new RichTextBox();
            SuspendLayout();
            // 
            // xemtruoctxt
            // 
            xemtruoctxt.Location = new Point(12, 12);
            xemtruoctxt.Name = "xemtruoctxt";
            xemtruoctxt.Size = new Size(372, 344);
            xemtruoctxt.TabIndex = 30;
            xemtruoctxt.Text = "";
            // 
            // btnin
            // 
            btnin.Location = new Point(265, 395);
            btnin.Name = "btnin";
            btnin.Size = new Size(94, 29);
            btnin.TabIndex = 31;
            btnin.Text = "In";
            btnin.UseVisualStyleBackColor = true;
            btnin.Click += btnin_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(465, 395);
            thoat.Name = "thoat";
            thoat.Size = new Size(94, 29);
            thoat.TabIndex = 32;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // back
            // 
            back.Location = new Point(365, 395);
            back.Name = "back";
            back.Size = new Size(94, 29);
            back.TabIndex = 33;
            back.Text = "Quay lại";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // phieuintxt
            // 
            phieuintxt.Enabled = false;
            phieuintxt.Location = new Point(404, 12);
            phieuintxt.Name = "phieuintxt";
            phieuintxt.Size = new Size(384, 344);
            phieuintxt.TabIndex = 34;
            phieuintxt.Text = "";
            // 
            // InPhieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(phieuintxt);
            Controls.Add(back);
            Controls.Add(thoat);
            Controls.Add(btnin);
            Controls.Add(xemtruoctxt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InPhieu";
            Text = "InPhieu";
            ResumeLayout(false);
        }

        #endregion

        private ListBox XemTruoc;
        private RichTextBox xemtruoctxt;
        private Button btnin;
        private Button thoat;
        private Button back;
        private RichTextBox phieuintxt;
    }
}