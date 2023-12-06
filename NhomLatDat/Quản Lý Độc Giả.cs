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

namespace NhomLatDat
{
    public partial class Quản_Lý_Độc_Giả : Form
    {
        DocGiaService _service = new DocGiaService();
        string username;
        string mk;
        public Quản_Lý_Độc_Giả(string user, string mk)
        {
            InitializeComponent();
            LoadData(_service.GetAll());
            ClearData();
            username = user;
            NhanVienService _NVservice = new NhanVienService();
            MaNv_ComboBox.DataSource = _NVservice.GetAll();
            MaNv_ComboBox.DisplayMember = "Manv";
            MaNv_ComboBox.ValueMember = "Manv";
            MaNv_ComboBox.Text = username;
            this.mk = mk;
        }
        public void LoadData(dynamic data)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 12;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Số thẻ";
            dataGridView1.Columns[2].Name = "Họ tên";
            dataGridView1.Columns[3].Name = "Giới tính";
            dataGridView1.Columns[4].Name = "Ngày sinh";
            dataGridView1.Columns[5].Name = "Địa chỉ";
            dataGridView1.Columns[6].Name = "Số điện thoại";
            dataGridView1.Columns[7].Name = "Email";
            dataGridView1.Columns[8].Name = "CCCD";
            dataGridView1.Columns[9].Name = "Mã nhân viên";
            dataGridView1.Columns[10].Name = "Ngày cấp";
            dataGridView1.Columns[11].Name = "Ngày hết hạn";
            int stt = 1;
            foreach (var x in data)
            {
                dataGridView1.Rows.Add(stt++, x.Sothe, x.Hoten, x.Gioitinh ? "Nam" : "Nữ", x.Ngaysinh, x.Diachi, x.Sdt, x.Email, x.Cccd, x.Manv, x.Ngaycap, x.Ngayhethan);
            }
        }
        public void ClearData()
        {
            textBox1.Text = HovaTen_Texbox.Text = CCCD_TextBox.Text = SDT_TextBox.Text = Email_TexBox.Text = DiaChi_Text.Text = "";
            Nam_Radio.Checked = Nu_Radio.Checked = false;
            dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Now;
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
                bool add = _service.Add(textBox1.Text, new Docgium
                {
                    Sothe = textBox1.Text,
                    Hoten = HovaTen_Texbox.Text,
                    Gioitinh = gt,
                    Ngaysinh = NgaySinh_DTP.Value,
                    Diachi = DiaChi_Text.Text,
                    Sdt = SDT_TextBox.Text,
                    Email = Email_TexBox.Text,
                    Cccd = CCCD_TextBox.Text,
                    Manv = MaNv_ComboBox.Text,
                    Ngaycap = dateTimePicker1.Value,
                    Ngayhethan = dateTimePicker2.Value
                });
                if (add)
                {
                    LoadData(_service.GetAll());
                    ClearData();
                    MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void Xoa_Btn_Click(object sender, EventArgs e)
        {
                bool add = _service.Delete(textBox1.Text);
                if (add)
                {
                    LoadData(_service.GetAll());
                    ClearData();
                    MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                bool add = _service.Update(textBox1.Text, new Docgium
                {
                    Hoten = HovaTen_Texbox.Text,
                    Gioitinh = gt,
                    Ngaysinh = NgaySinh_DTP.Value,
                    Diachi = DiaChi_Text.Text,
                    Sdt = SDT_TextBox.Text,
                    Email = Email_TexBox.Text,
                    Cccd = CCCD_TextBox.Text,
                    Manv = MaNv_ComboBox.Text,
                    Ngaycap = dateTimePicker1.Value,
                    Ngayhethan = dateTimePicker2.Value
                });
                if (add)
                {
                    LoadData(_service.GetAll());
                    ClearData();
                    MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void Thoat_Btn_Click(object sender, EventArgs e)
        {
            TrangChu menu = new TrangChu(username, mk);
            menu.Show();
            this.Hide();
        }

        private void TimKiemTen_Btn_Click(object sender, EventArgs e)
        {
            LoadData(_service.GetById(TimKiemTen_Texbox.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selected = dataGridView1.Rows[index];
            textBox1.Text = selected.Cells[1].Value.ToString();
            HovaTen_Texbox.Text = selected.Cells[2].Value.ToString();
            if (selected.Cells[3].Value.ToString() == "Nam")
            {
                Nam_Radio.Checked = true;
                Nu_Radio.Checked = false;
            }
            else
            {
                Nam_Radio.Checked = false;
                Nu_Radio.Checked = true;
            }
            NgaySinh_DTP.Value = (DateTime)selected.Cells[4].Value;
            DiaChi_Text.Text = selected.Cells[5].Value.ToString();
            SDT_TextBox.Text = selected.Cells[6].Value.ToString();
            Email_TexBox.Text = selected.Cells[7].Value.ToString();
            CCCD_TextBox.Text = selected.Cells[8].Value.ToString();
            MaNv_ComboBox.SelectedValue = selected.Cells[9].Value;
            dateTimePicker1.Value = (DateTime)selected.Cells[10].Value;
            dateTimePicker2.Value = (DateTime)selected.Cells[11].Value;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void HovaTen_Texbox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CCCD_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SDT_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
