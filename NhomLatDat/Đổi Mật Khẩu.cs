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
    public partial class Đổi_Mật_Khẩu : Form
    {
        NhanVienService _service = new NhanVienService();
        string username;
        string mk;
        public Đổi_Mật_Khẩu(string username, string mk)
        {
            InitializeComponent();
            this.username = username;
            this.mk = mk;
        }

        private void Đổi_Mật_Khẩu_Load(object sender, EventArgs e)
        {

        }

        private void DoiMatKhau_Btn_Click(object sender, EventArgs e)
        {
            if(MatKhauMoi_Texbox.Text !=""&& NhapLaiMatKhauMoi_TextBox.Text != "" && NhapLaiMatKhauMoi_TextBox.Text != "")
            {
                if (MatKhauMoi_Texbox.Text == NhapLaiMatKhauMoi_TextBox.Text)
                {
                    bool doi = _service.ChangePassword(username, MatKhauCu_Texbox.Text, MatKhauMoi_Texbox.Text);
                    if (doi)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Thoat_Btn_Click(object sender, EventArgs e)
        {
            TrangChu trangChu = new TrangChu(username, mk);
            trangChu.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MatKhauCu_Texbox.UseSystemPasswordChar = MatKhauMoi_Texbox.UseSystemPasswordChar = NhapLaiMatKhauMoi_TextBox.UseSystemPasswordChar = false;
            }
            else
            {
                MatKhauCu_Texbox.UseSystemPasswordChar = MatKhauMoi_Texbox.UseSystemPasswordChar = NhapLaiMatKhauMoi_TextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
