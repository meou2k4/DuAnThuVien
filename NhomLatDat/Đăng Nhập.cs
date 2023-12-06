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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NhomLatDat
{
    public partial class Đăng_Nhập : Form
    {
        NhanVienService _service = new NhanVienService();
        public Đăng_Nhập()
        {
            InitializeComponent();
        }

        private void Đăng_Nhập_Load(object sender, EventArgs e)
        {

        }

        private void DoiMatKhau_Btn_Click(object sender, EventArgs e)
        {
            string username = MatKhauCu_Texbox.Text;
            string pass = MatKhauMoi_Texbox.Text;
            
            if(username !="" && pass != "")
            {
                if (_service.GetNhanVien(username, pass) != null)
                {
                    TrangChu trangChu = new TrangChu(username, pass);
                    trangChu.Show();
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Thoat_Btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MatKhauMoi_Texbox.UseSystemPasswordChar = false;
            }
            else
            {
                MatKhauMoi_Texbox.UseSystemPasswordChar = true;
            }
        }

        private void QuenMatKhau_Click(object sender, EventArgs e)
        {
            Quên_mật_khẩu q = new Quên_mật_khẩu();
            q.Show();
            this.Hide();
        }
    }
}
