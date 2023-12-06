using BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhomLatDat
{
    public partial class Quên_mật_khẩu : Form
    {
        NhanVienService _service = new NhanVienService();
        public Quên_mật_khẩu()
        {
            InitializeComponent();
        }

        private void QuenMatKhau_Click(object sender, EventArgs e)
        {
            var a = _service.ForgetPass(SDTtext.Text, MatKhauMoi_Texbox.Text);
            if (MatKhauMoi_Texbox.Text == textBox1.Text)
            {
                if (a)
                {
                    MessageBox.Show($"Lấy lại mật khẩu thành công!\nMật khẩu mới của bạn là: {MatKhauMoi_Texbox.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lấy lại mật khẩu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SDTtext.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MatKhauMoi_Texbox.UseSystemPasswordChar = false;
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                MatKhauMoi_Texbox.UseSystemPasswordChar = true;
                textBox1.UseSystemPasswordChar = true;
            }

        }

        private void Thoat_Btn_Click(object sender, EventArgs e)
        {
            Đăng_Nhập d = new Đăng_Nhập();
            d.Show();
            this.Hide();
        }

        private void Quên_mật_khẩu_Load(object sender, EventArgs e)
        {

        }
    }
}
