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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NhomLatDat
{
    public partial class Trả_Sách : Form
    {
        string phieu;
        string phieuct;
        TraSachCTService _CTservice = new TraSachCTService();
        TraSachService _service = new TraSachService();
        
        string manv;
        string mk;
        int s;
        public Trả_Sách(string manv, string mk)
        {
            InitializeComponent();
            LoadCombobox();
            this.manv = manv;
            this.mk = mk;
            LoadView1(_service.GetAll());
            ClearData();
        }
        public void LoadCombobox()
        {
            SachService _Sservice = new SachService();
            NhanVienService _NVService = new NhanVienService();
            DocGiaService _DGservice = new DocGiaService();
            //combobox Madocgia
            MaDocGia_ComboBox.DataSource = _DGservice.GetAll();
            MaDocGia_ComboBox.DisplayMember = "Sothe";
            MaDocGia_ComboBox.ValueMember = "Sothe";
            MaDocGia_ComboBox.SelectedIndex = -1;
            Manvcmb.DataSource = _NVService.GetAll();
            Manvcmb.DisplayMember = "Manv";
            Manvcmb.ValueMember = "Manv";
            MaSach_Combobox.DataSource = _Sservice.GetAll();
            MaSach_Combobox.DisplayMember = "Masach";
            MaSach_Combobox.ValueMember = "Masach";
            Manvcmb.SelectedIndex = -1;
            MaSach_Combobox.SelectedIndex = -1;
        }
        public void ClearData()
        {
            IDPhieu_Textbox.Text = "";
            textBox1.Text = "";

            NgayMuonDate.Value = NgayTraDate.Value = HanTraDate.Value = DateTime.Now;
            MaDocGia_ComboBox.SelectedIndex = -1;
            Manvcmb.SelectedIndex = -1;
            MaSach_Combobox.SelectedIndex = -1; SoLuong_Textbox.Text = "";
        }
        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mượn_Sách m = new Mượn_Sách(manv, mk);
            m.Show();
            this.Hide();
        }

        private void nhậpSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xử_Lý_Vi_Phạm xl = new Xử_Lý_Vi_Phạm(manv, mk);
            xl.Show();
            this.Hide();

        }

        private void xửLýViPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xử_Lý_Vi_Phạm xl = new Xử_Lý_Vi_Phạm(manv, mk);
            xl.Show();
            this.Hide();
        }
        public void LoadView1(dynamic data)
        {
            view1.Rows.Clear();
            view1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            view1.ColumnCount = 8;
            int stt = 1;
            view1.Columns[0].Name = "STT";
            view1.Columns[1].Name = "Mã phiếu";
            view1.Columns[2].Name = "Số thẻ";
            view1.Columns[3].Name = "Mã nhân viên";
            view1.Columns[4].Name = "Ngày mượn";
            view1.Columns[5].Name = "Hạn trả";
            view1.Columns[6].Name = "Ngày trả";
            view1.Columns[7].Name = "Trạng thái";
            foreach (var x in data)
            {
                view1.Rows.Add(stt++, x.Matra, x.Sothe, x.Manv, x.Ngaymuon, x.Hantra, x.Ngaytra, x.Trangthai);
            }
        }
        public void LoadView2(dynamic data)
        {
            view2.Rows.Clear();
            view2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            view2.ColumnCount = 4;
            view2.Columns[0].Name = "ID";
            view2.Columns[0].Visible = false;
            view2.Columns[1].Name = "Mã phiếu";
            view2.Columns[1].Visible = false;
            view2.Columns[2].Name = "Mã sách";
            view2.Columns[3].Name = "Số lượng";
            foreach (var x in data)
            {
                view2.Rows.Add(x.Id, x.Matra, x.Masach, x.Soluong);
            }
        }

        private void view1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selected = view1.Rows[index];
            IDPhieu_Textbox.Text = selected.Cells[1].Value.ToString();
            MaDocGia_ComboBox.SelectedValue = selected.Cells[2].Value;
            Manvcmb.SelectedValue = selected.Cells[3].Value;
            NgayMuonDate.Value = (DateTime)selected.Cells[4].Value;
            HanTraDate.Value = (DateTime)selected.Cells[5].Value;
            NgayTraDate.Value = (DateTime)selected.Cells[6].Value;
            textBox1.Text = selected.Cells[7].Value.ToString();
            LoadView2(_CTservice.GetByID(IDPhieu_Textbox.Text));

            phieu = $"Thông tin phiếu:\n" + $"Mã phiếu: {IDPhieu_Textbox.Text}\n" + $"Tên độc giả: {MaDocGia_ComboBox.Text}\n" + $"Nhân viên thực hiện: {Manvcmb.Text}\n" + $"Ngày mượn: {NgayMuonDate.Value}\n" + $"Hạn trả: {HanTraDate.Value}\n" +
                $"Ngày trả: {NgayTraDate.Value}\n"
                + $"\nTrạng thái: {textBox1.Text}\n";
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            var a = _service.AddTraSach(IDPhieu_Textbox.Text, new Phieutra
            {
                Matra = IDPhieu_Textbox.Text,
                Manv = Manvcmb.Text,
                Sothe = MaDocGia_ComboBox.Text,
                Ngaymuon = NgayMuonDate.Value,
                Hantra = HanTraDate.Value,
                Ngaytra = NgayTraDate.Value,
                Trangthai = textBox1.Text
            });
            if (a)
            {

                LoadView1(_service.GetAll());
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã phiếu đã bị trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var a = _service.UpdateTraSach(IDPhieu_Textbox.Text, new Phieutra
            {
                Manv = Manvcmb.Text,
                Sothe = MaDocGia_ComboBox.Text,
                Ngaymuon = NgayMuonDate.Value,
                Hantra = HanTraDate.Value,
                Ngaytra = NgayTraDate.Value,
                Trangthai = textBox1.Text
            });
            if (a)
            {
                LoadView1(_service.GetAll());
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsach_Click(object sender, EventArgs e)
        {
            var a = _service.DeleteTraSach(IDPhieu_Textbox.Text);
            if (a)
            {
                ClearData();
                LoadView1(_service.GetAll());
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthemsach_Click(object sender, EventArgs e)
        {
            var a = _CTservice.Add(new Phieutract
            {
                Matra = IDPhieu_Textbox.Text,
                Masach = MaSach_Combobox.Text,
                Soluong = int.Parse(SoLuong_Textbox.Text)
            }, int.Parse(SoLuong_Textbox.Text), MaSach_Combobox.Text);
            if (a)
            {
                MaSach_Combobox.SelectedIndex = -1; SoLuong_Textbox.Text = "";
                LoadView2(_CTservice.GetByID(IDPhieu_Textbox.Text));
            }
        }

        private void btnsuasach_Click(object sender, EventArgs e)
        {
            var a = _CTservice.Update(int.Parse(lblid.Text), new Phieutract
            {
                Matra = IDPhieu_Textbox.Text,
                Masach = MaSach_Combobox.Text,
                Soluong = int.Parse(SoLuong_Textbox.Text)
            }, int.Parse(SoLuong_Textbox.Text), s, MaSach_Combobox.Text);
            if (a)
            {
                MaSach_Combobox.SelectedIndex = -1; SoLuong_Textbox.Text = "";
                LoadView2(_CTservice.GetByID(IDPhieu_Textbox.Text));
            }
        }

        private void btnxoasach_Click(object sender, EventArgs e)
        {
            var a = _CTservice.Delete(int.Parse(lblid.Text), s, MaSach_Combobox.Text);
            if (a)
            {
                MaSach_Combobox.SelectedIndex = -1; SoLuong_Textbox.Text = "";
                LoadView2(_CTservice.GetByID(IDPhieu_Textbox.Text));
            }
        }

        private void TimKiemTen_Btn_Click(object sender, EventArgs e)
        {
            LoadView2(_CTservice.GetByID(IDPhieu_Textbox.Text));
            LoadView1(_service.GetById(IDPhieu_Textbox.Text));
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            TrangChu t = new TrangChu(manv, mk);
            t.Show();
            this.Hide();
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            InPhieu i = new InPhieu(manv, mk, $"{phieu} \n{phieuct}");
            i.Show();
            this.Hide();
        }
    }
}
