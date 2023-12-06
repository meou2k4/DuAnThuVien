using BUS.Service;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NhomLatDat
{
    public partial class Quản_Lý_Nhân_Viên : Form
    {
        string manv;
        string mk;
        NhanVienService _service = new NhanVienService();
        public Quản_Lý_Nhân_Viên(string manv, string mk)
        {
            InitializeComponent();
            LoadData(_service.GetAll());
            ClearData();
            ChucDanh_Textbox.Enabled = false;
            this.manv = manv;
            this.mk = mk;
        }
        public void ClearData()
        {
            Nam_Radio.Checked = false;
            Nu_Radio.Checked = false;
            IDNhanVien_Texbox.Text = "";
            HovaTen_Texbox.Text = "";
            NgaySinh_DTP.Value = DateTime.Now;
            DiaChi_TextBox.Text = "";
            SDT_TextBox.Text = "";
            Email_TexBox.Text = "";
            CCCD_Textbox.Text = "";
            Password_Textbox.Text = "";
            ChucDanh_Textbox.Text = "Nhân viên";
        }
        public void LoadData(dynamic data)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 11;
            int stt = 1;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã nhân viên";
            dataGridView1.Columns[2].Name = "Họ Tên";
            dataGridView1.Columns[3].Name = "Giới tính";
            dataGridView1.Columns[4].Name = "Ngày sinh";
            dataGridView1.Columns[5].Name = "Địa chỉ";
            dataGridView1.Columns[6].Name = "Số điện thoại";
            dataGridView1.Columns[7].Name = "Email";
            dataGridView1.Columns[8].Name = "CCCD";
            dataGridView1.Columns[9].Name = "Chức danh";
            dataGridView1.Columns[10].Name = "Mật khẩu";
            dataGridView1.Columns[10].Visible = false;
            foreach (var x in data)
            {
                dataGridView1.Rows.Add(stt++, x.Manv, x.Hoten, x.Gioitinh ? "Nam" : "Nữ", x.Ngaysinh, x.Diachi, x.Sdt, x.Email, x.Cccd, x.Chucdanh, x.Password);
            }
        }
        private void Them_Btn_Click(object sender, EventArgs e)
        {
            bool gt;
            if (Nam_Radio.Checked)
            {
                gt = true;
            }
            else
            {
                gt = false;
            }
                bool add = _service.Add(IDNhanVien_Texbox.Text, new Nhanvien
                {
                    Manv = IDNhanVien_Texbox.Text,
                    Hoten = HovaTen_Texbox.Text,
                    Gioitinh = gt,
                    Ngaysinh = NgaySinh_DTP.Value,
                    Diachi = DiaChi_TextBox.Text,
                    Sdt = SDT_TextBox.Text,
                    Email = Email_TexBox.Text,
                    Cccd = CCCD_Textbox.Text,
                    Password = Password_Textbox.Text,
                    Chucdanh = ChucDanh_Textbox.Text
                });
                if (add)
                {
                    LoadData(_service.GetAll());
                    ClearData();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void Xoa_Btn_Click(object sender, EventArgs e)
        {
            
                var xoa = _service.Delete(IDNhanVien_Texbox.Text);
                if (xoa)
                {
                    LoadData(_service.GetAll());
                    ClearData();
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void Sua_Btn_Click(object sender, EventArgs e)
        {
            bool gt;
            if (Nam_Radio.Checked)
            {
                gt = true;
            }
            else
            {
                gt = false;
            }
                bool sua = _service.Update(IDNhanVien_Texbox.Text, new Nhanvien
                {
                    Hoten = HovaTen_Texbox.Text,
                    Gioitinh = gt,
                    Ngaysinh = NgaySinh_DTP.Value,
                    Diachi = DiaChi_TextBox.Text,
                    Sdt = SDT_TextBox.Text,
                    Email = Email_TexBox.Text,
                    Cccd = CCCD_Textbox.Text,
                    Password = Password_Textbox.Text,
                    Chucdanh = ChucDanh_Textbox.Text
                });
                if (sua)
                {
                    LoadData(_service.GetAll());
                    ClearData();
                    MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selected = dataGridView1.Rows[index];
            IDNhanVien_Texbox.Text = selected.Cells[1].Value.ToString();
            HovaTen_Texbox.Text = selected.Cells[2].Value.ToString();
            if (selected.Cells[3].Value.ToString() == "Nam")
            {
                Nam_Radio.Checked = true; Nu_Radio.Checked = false;
            }
            else
            {
                Nu_Radio.Checked = true; Nam_Radio.Checked = false;
            }
            NgaySinh_DTP.Value = (DateTime)selected.Cells[4].Value;
            DiaChi_TextBox.Text = selected.Cells[5].Value.ToString();
            SDT_TextBox.Text = selected.Cells[6].Value.ToString();
            Email_TexBox.Text = selected.Cells[7].Value.ToString();
            CCCD_Textbox.Text = selected.Cells[8].Value.ToString();
            Password_Textbox.Text = selected.Cells[10].Value.ToString();
            ChucDanh_Textbox.Text = selected.Cells[9].Value.ToString();
        }

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void Thoat_Btn_Click(object sender, EventArgs e)
        {
            TrangChu trangChu = new TrangChu(manv, mk);
            trangChu.Show();
            this.Hide();
        }

        private void TimKiemTen_Btn_Click(object sender, EventArgs e)
        {
            var tk = _service.GetById(TimKiemTen_Texbox.Text);
            LoadData(tk);
        }
    }
}
