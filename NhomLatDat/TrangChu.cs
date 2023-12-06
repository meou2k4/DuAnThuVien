using BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows.Forms;

namespace NhomLatDat
{
    public partial class TrangChu : Form
    {
        string username;
        string mk;
        NhanVienService _service = new NhanVienService();
        public TrangChu(string username, string pass)
        {
            InitializeComponent();
            mk = pass;
            this.username = username;
            
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void quảLýNhânViẻnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_service.GetAdmin(username, mk))
            {
                Quản_Lý_Nhân_Viên nv = new Quản_Lý_Nhân_Viên(username, mk);
                nv.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chỉ có quản trị viên có thể xem thông tin nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void đổiMaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Đổi_Mật_Khẩu a = new Đổi_Mật_Khẩu(username, mk);
            a.Show();
            this.Hide();
        }

        private void quảnLýNhậpSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void quảnLýSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Quản_Lý_Sách sach = new Quản_Lý_Sách(username, mk);
            sach.Show();
            this.Hide();
        }

        private void quảnLýThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quản_Lý_Thể_Loại tl = new Quản_Lý_Thể_Loại(username, mk);
            tl.Show();
            this.Hide();
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quản_Lý_Tác_Giả tg = new Quản_Lý_Tác_Giả(username, mk);
            tg.Show();
            this.Hide();
        }

        private void quảnLýNgônNgữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quản_Lý_Ngôn_Ngữ nn = new Quản_Lý_Ngôn_Ngữ(username, mk);
            nn.Show();
            this.Hide();
        }

        private void quảnLýMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mượn_Sách muon = new Mượn_Sách(username, mk);
            muon.Show();
            this.Hide();
        }

        private void quảnLýTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trả_Sách tra = new Trả_Sách(username, mk);
            tra.Show();
            this.Hide();
        }

        private void quảnLýNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quản_Lý_Nhà_Xuất_Bản nxb = new Quản_Lý_Nhà_Xuất_Bản(username, mk);
            nxb.Show();
            this.Hide();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quản_Lý_Độc_Giả dg = new Quản_Lý_Độc_Giả(username, mk);
            dg.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Đăng_Nhập đăng = new Đăng_Nhập();
            đăng.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void thốngKêSốLượngSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thống_kê_số_lượng tk = new Thống_kê_số_lượng(username, mk);
            tk.Show();
            this.Hide();
        }

        private void thốngKêQuáHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thống_kê_quá_hạn tk = new Thống_kê_quá_hạn(username, mk);
            tk.Show();
            this.Hide();
        }

        private void xửLýViPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xử_Lý_Vi_Phạm xl = new Xử_Lý_Vi_Phạm(username, mk);
            xl.Show();
            this.Hide();
        }
    }
}
