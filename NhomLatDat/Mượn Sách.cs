using BUS.Service;
using DAL.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NhomLatDat
{
    public partial class Mượn_Sách : Form
    {
        string phieu;
        string phieuct;
        int s;
        MuonSachService _service = new MuonSachService();
        MuonSachCTService _CTservice = new MuonSachCTService();
        string manv;
        string mk;
        public Mượn_Sách(string username, string pass)
        {
            mk = pass;
            InitializeComponent();
            LoadView1(_service.GetAll());
            ClearData();
            LoadCombobox();
            manv = username;

        }
        public void ClearData()
        {
            IDPhieu_Textbox.Text = "";
            TrangThai_Textbox.Text = "";

            dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Now;
            MaDocGia_ComboBox.SelectedIndex = -1;
            Manvcmb.SelectedIndex = -1;
            MaSach_Combobox.SelectedIndex = -1; SoLuong_Textbox.Text = "";
        }
        public void LoadCombobox()
        {
            DocGiaService docGiaService = new DocGiaService();
            MaDocGia_ComboBox.DataSource = docGiaService.GetAll();
            MaDocGia_ComboBox.DisplayMember = "Sothe";
            MaDocGia_ComboBox.ValueMember = "Sothe";
            MaDocGia_ComboBox.SelectedIndex = -1;
            SachService sachService = new SachService();
            MaSach_Combobox.DataSource = sachService.GetAll();
            MaSach_Combobox.DisplayMember = "Masach";
            MaSach_Combobox.ValueMember = "Masach";
            MaSach_Combobox.SelectedIndex = -1;
            NhanVienService nhanVienService = new NhanVienService();
            Manvcmb.DataSource = nhanVienService.GetAll();
            Manvcmb.DisplayMember = "Manv";
            Manvcmb.ValueMember = "Manv";
            Manvcmb.SelectedIndex = -1;
        }
        public void LoadView1(dynamic data)
        {
            view1.Rows.Clear();
            view1.ColumnCount = 7;
            int stt = 1;
            view1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            view1.Columns[0].Name = "STT";
            view1.Columns[1].Name = "Mã phiếu";
            view1.Columns[2].Name = "Số thẻ";
            view1.Columns[3].Name = "Mã nhân viên";
            view1.Columns[4].Name = "Ngày mượn";
            view1.Columns[5].Name = "Hạn trả";
            view1.Columns[6].Name = "Trạng thái";
            foreach (var x in data)
            {
                view1.Rows.Add(stt++, x.Mamuon, x.Sothe, x.Manv, x.Ngaymuon, x.Hantra, x.Trangthai);
            }
        }
        public void LoadView2(dynamic data)
        {
            view2.Rows.Clear();
            view2.ColumnCount = 4;
            view2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            view2.Columns[0].Name = "ID";
            view2.Columns[0].Visible = false;
            view2.Columns[1].Name = "Mã phiếu";
            view2.Columns[1].Visible = false;
            view2.Columns[2].Name = "Mã sách";
            view2.Columns[3].Name = "Số lượng";
            foreach (var x in data)
            {
                view2.Rows.Add(x.Id, x.Mamuon, x.Masach, x.Soluong);
            }
        }

        private void TimKiemTen_Btn_Click(object sender, EventArgs e)
        {
            LoadView1(_service.GetById(IDPhieu_Textbox.Text));
            LoadView2(_CTservice.GetById(IDPhieu_Textbox.Text));
        }


        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trả_Sách tra = new Trả_Sách(manv, mk);
            tra.Show();
            this.Hide();
        }
        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            InPhieu p = new InPhieu(manv, mk, phieu);
            p.Show();
            this.Hide();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            var a = _service.AddMuonSach(IDPhieu_Textbox.Text, new Phieumuon
            {
                Mamuon = IDPhieu_Textbox.Text,
                Sothe = MaDocGia_ComboBox.Text,
                Ngaymuon = dateTimePicker1.Value,
                Hantra = dateTimePicker2.Value,
                Manv = Manvcmb.Text,
                Trangthai = TrangThai_Textbox.Text
            });
            if (a)
            {
                LoadView1(_service.GetAll());
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void view1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selected = view1.Rows[index];
            IDPhieu_Textbox.Text = selected.Cells[1].Value.ToString();
            MaDocGia_ComboBox.SelectedValue = selected.Cells[2].Value;
            Manvcmb.SelectedValue = selected.Cells[3].Value;
            dateTimePicker1.Value = (DateTime)selected.Cells[4].Value;
            dateTimePicker2.Value = (DateTime)selected.Cells[5].Value;
            TrangThai_Textbox.Text = (string)selected.Cells[6].Value;
            LoadView2(_CTservice.GetById(IDPhieu_Textbox.Text));
            phieu = $"Thông tin phiếu:\n" + $"Mã phiếu: {IDPhieu_Textbox.Text}\n" + $"Tên độc giả: {MaDocGia_ComboBox.Text}\n" + $"Nhân viên thực hiện: {Manvcmb.Text} \n" + $"Ngày mượn: {dateTimePicker1.Value}\n" + $"Hạn trả: {dateTimePicker2.Value}`"
                + $"\nTrạng thái: {TrangThai_Textbox.Text}\n";
        }

        private void view2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selected = view2.Rows[index];
            lblid.Text = selected.Cells[0].Value.ToString();
            IDPhieu_Textbox.Text = selected.Cells[1].Value.ToString();
            MaSach_Combobox.SelectedValue = selected.Cells[2].Value;
            SoLuong_Textbox.Text = selected.Cells[3].Value.ToString();
            s = (int)selected.Cells[3].Value;
            phieuct = $"Chi tiết phiếu:\n" +
                $"Tên sách: {SoLuong_Textbox.Text}";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var a = _service.UpdateMuonSach(IDPhieu_Textbox.Text, new Phieumuon
            {
                Sothe = MaDocGia_ComboBox.Text,
                Ngaymuon = dateTimePicker1.Value,
                Hantra = dateTimePicker2.Value,
                Manv = Manvcmb.Text,
                Trangthai = TrangThai_Textbox.Text
            });
            if (a)
            {
                LoadView1(_service.GetAll());
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var a = _service.DeleteMuonSach(IDPhieu_Textbox.Text);

            if (a)
            {
                LoadView1(_service.GetAll());
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthemct_Click(object sender, EventArgs e)
        {
            var a = _CTservice.Add(new Phieumuonct
            {
                Mamuon = IDPhieu_Textbox.Text,
                Masach = MaSach_Combobox.Text,
                Soluong = int.Parse(SoLuong_Textbox.Text)
            }, int.Parse(SoLuong_Textbox.Text), MaSach_Combobox.Text);
            if (a)
            {
                ClearData();
                LoadView2(_CTservice.GetById(IDPhieu_Textbox.Text));
            }
        }

        private void btnsuact_Click(object sender, EventArgs e)
        {
            var a = _CTservice.Update(int.Parse(lblid.Text), new Phieumuonct
            {
                Masach = MaSach_Combobox.Text,
                Soluong = int.Parse(SoLuong_Textbox.Text)
            }, s, int.Parse(SoLuong_Textbox.Text), MaSach_Combobox.Text);
            if (a)
            {
                ClearData();
                LoadView2(_CTservice.GetById(IDPhieu_Textbox.Text));
            }
        }

        private void btnxoact_Click(object sender, EventArgs e)
        {
            var a = _CTservice.Delete(int.Parse(lblid.Text), int.Parse(SoLuong_Textbox.Text), MaSach_Combobox.Text);
            if (a)
            {
                ClearData();
                LoadView2(_CTservice.GetById(IDPhieu_Textbox.Text));
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            TrangChu t = new TrangChu(manv, mk);
            t.Show();
            this.Hide();
        }

        private void btnInPhieu_Click_1(object sender, EventArgs e)
        {
            InPhieu i = new InPhieu(manv, mk, $"{phieu} \n{phieuct}");
            i.Show();
            this.Hide();
        }
    }
}
