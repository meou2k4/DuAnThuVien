using BUS.Service;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace NhomLatDat
{
    public partial class Quản_Lý_Sách : Form
    {
        string username;
        SachCTService _CTservice = new SachCTService();
        SachService _service = new SachService();
        string mk;
        public Quản_Lý_Sách(string username, string mk)
        {
            InitializeComponent();
            LoadDatas(_service.GetAll());
            ClearData();
            LoadCombobox();
            this.username = username;
            this.mk = mk;
        }
        public void LoadCombobox()
        {
            TacGiaService _TGservice = new TacGiaService();
            TheLoaiService _TLservice = new TheLoaiService();
            NgonNguService _NNservice = new NgonNguService();
            NhaXBService _NXBservice = new NhaXBService();
            //combobox Tac Gia
            TacGia_ComboBox.DataSource = _TGservice.GetAll();
            TacGia_ComboBox.DisplayMember = "Matacgia";
            TacGia_ComboBox.ValueMember = "Matacgia";
            TacGia_ComboBox.SelectedIndex = -1;
            //combobox The Loai
            TheLoai_ComboBox.DataSource = _TLservice.GetAll();
            TheLoai_ComboBox.DisplayMember = "Matheloai";
            TheLoai_ComboBox.ValueMember = "Matheloai";
            TheLoai_ComboBox.SelectedIndex = -1;
            //combobox ngon ngu
            NgonNgu_ComboBox.DataSource = _NNservice.GetAll();
            NgonNgu_ComboBox.DisplayMember = "Mangonngu";
            NgonNgu_ComboBox.ValueMember = "Mangonngu";
            NgonNgu_ComboBox.SelectedIndex = -1;
            //combobox nha xuat ban
            cmbNXB.DataSource = _NXBservice.GetAll();
            cmbNXB.DisplayMember = "Tennxb";
            cmbNXB.ValueMember = "Manxb";
            cmbNXB.SelectedIndex = -1;
        }
        public void LoadData(dynamic datas)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Name = "Mã sách";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Name = "Tác giả";
            dataGridView1.Columns[3].Name = "Thể loại";
            dataGridView1.Columns[4].Name = "Ngôn ngữ";
            foreach (var x in datas)
            {
                dataGridView1.Rows.Add(x.Id, x.Masach, x.Matacgia, x.Matheloai, x.Mangonngu);
            }
        }
        public void LoadDatas(dynamic data)
        {
            view.Rows.Clear();
            view.ColumnCount = 9;
            view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int stt = 1;
            view.Columns[0].Name = "STT";
            view.Columns[1].Name = "Mã sách";
            view.Columns[2].Name = "Tên sách";
            view.Columns[3].Name = "Nhà xuất bản";
            view.Columns[4].Name = "Ngày xuất bản";
            view.Columns[5].Name = "Ngày cập nhật";
            view.Columns[6].Name = "Số lượng";
            view.Columns[7].Name = "Số trang";
            view.Columns[8].Name = "Trạng thái";
            foreach (var x in data)
            {
                view.Rows.Add(stt++, x.Masach, x.Tensach, x.Manxb, x.Ngayxb, x.Ngaycn, x.Soluong, x.Sotrang, x.Trangthai);
            }
        }
        public void ClearData()
        {
            textBox1.Text = "";
            TenSach_Texbox.Text = "";
            TacGia_ComboBox.SelectedValue = -1;
            TheLoai_ComboBox.SelectedValue = -1;
            NgonNgu_ComboBox.SelectedValue = -1;
            NgonNgu_ComboBox.SelectedValue = -1;
            cmbNXB.SelectedValue = -1;
            NgayCapNhat_Date.Value = NgayXuatBan_Date.Value = DateTime.Now;
            SoLuong_TexBox.Text = "";
            SoTrang_TexBox.Text = "";
            TrangThai_Textbox.Text = "";
        }

        private void Them_Btn_Click(object sender, EventArgs e)
        {
            var a = _service.AddSach(textBox1.Text, new Sach
            {
                Masach = textBox1.Text,
                Tensach = TenSach_Texbox.Text,
                Soluong = int.Parse(SoLuong_TexBox.Text),
                Ngaycn = NgayCapNhat_Date.Value,
                Manxb = cmbNXB.Text,
                Ngayxb = NgayXuatBan_Date.Value,
                Sotrang = int.Parse(SoTrang_TexBox.Text),
                Trangthai = TrangThai_Textbox.Text
            });
            if (a)
            {
                LoadDatas(_service.GetAll());
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sua_Btn_Click(object sender, EventArgs e)
        {
            var a = _service.UpdateSach(textBox1.Text, new Sach
            {
                Tensach = TenSach_Texbox.Text,
                Soluong = int.Parse(SoLuong_TexBox.Text),
                Ngaycn = NgayCapNhat_Date.Value,
                Manxb = cmbNXB.Text,
                Ngayxb = NgayXuatBan_Date.Value,
                Sotrang = int.Parse(SoTrang_TexBox.Text),
                Trangthai = TrangThai_Textbox.Text
            });
            if (a)
            {
                LoadDatas(_service.GetAll());
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Xoa_Btn_Click(object sender, EventArgs e)
        {
            var a = _service.DeleteSach(textBox1.Text);
            var b = _CTservice.DeleteSachAll(textBox1.Text);
            if (a && b)
            {
                LoadDatas(_service.GetAll());
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Đã có phiếu mã {textBox1.Text}! Vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selected = view.Rows[index];
            textBox1.Text = selected.Cells[1].Value.ToString();
            TenSach_Texbox.Text = selected.Cells[2].Value.ToString();
            cmbNXB.SelectedValue = selected.Cells[3].Value;
            NgayXuatBan_Date.Value = (DateTime)selected.Cells[4].Value;
            NgayCapNhat_Date.Value = (DateTime)selected.Cells[5].Value;
            SoLuong_TexBox.Text = selected.Cells[6].Value.ToString();
            SoTrang_TexBox.Text = selected.Cells[7].Value.ToString();
            TrangThai_Textbox.Text = (string)selected.Cells[8].Value;
            LoadData(_CTservice.GetById(textBox1.Text));
        }

        private void btnthemCT_Click(object sender, EventArgs e)
        {
            var a = _CTservice.AddSach(new Sachchitiet
            {
                Masach = textBox1.Text,
                Mangonngu = NgonNgu_ComboBox.Text,
                Matacgia = TacGia_ComboBox.Text,
                Matheloai = TheLoai_ComboBox.Text
            });
            if (a)
            {
                LoadData(_CTservice.GetById(textBox1.Text));
                ClearData();
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            var a = _CTservice.UpdateSach(int.Parse(lblid.Text), new Sachchitiet
            {
                Mangonngu = NgonNgu_ComboBox.Text,
                Matacgia = TacGia_ComboBox.Text,
                Matheloai = TheLoai_ComboBox.Text
            });
            if (a)
            {
                LoadData(_CTservice.GetById(textBox1.Text));
                ClearData();
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoct_Click(object sender, EventArgs e)
        {
            var a = _CTservice.DeleteSachAll(textBox1.Text);
            if (a)
            {
                LoadData(_CTservice.GetById(textBox1.Text));
                ClearData();
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selected = dataGridView1.Rows[index];
            lblid.Text = selected.Cells[0].Value.ToString();
            textBox1.Text = selected.Cells[1].Value.ToString();
            TacGia_ComboBox.SelectedValue = selected.Cells[2].Value;
            TheLoai_ComboBox.SelectedValue = selected.Cells[3].Value;
            NgonNgu_ComboBox.SelectedValue = selected.Cells[4].Value;

        }

        private void TimKiemTen_Texbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimKiemTen_Btn_Click(object sender, EventArgs e)
        {
            LoadData(_CTservice.GetById(textBox1.Text));
            LoadDatas(_service.GetById(textBox1.Text));
        }

        private void Thoat_Btn_Click(object sender, EventArgs e)
        {
            TrangChu t = new TrangChu(username, mk);
            t.Show();
            this.Hide();
        }

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
