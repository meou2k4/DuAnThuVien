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
    public partial class Xử_Lý_Vi_Phạm : Form
    {
        string mk;
        string manv;
        XuLyService _servie = new XuLyService();
        DocGiaService _gia = new DocGiaService();
        NhanVienService _nv = new NhanVienService();
        TraSachService _s = new TraSachService();
        public Xử_Lý_Vi_Phạm(string manv, string mk)
        {
            InitializeComponent();
            this.manv = manv;
            LoadData(_servie.GetAll());
            ClearData();
            LoadCombobox();
            this.mk = mk;
        }
        public void LoadCombobox()
        {
            
            ///Matra
            matra_combobox.DataSource = _s.QuaHan();
            matra_combobox.DisplayMember = "Matra";
            matra_combobox.ValueMember = "Matra";
            matra_combobox.SelectedIndex = -1;
            //doc gia
            MaDocGia_Combobox.DataSource = _gia.GetAll();
            MaDocGia_Combobox.DisplayMember = "Sothe";
            MaDocGia_Combobox.ValueMember = "Sothe";
            MaDocGia_Combobox.SelectedIndex = -1;
            //Nhan vien
            MaNV_ComboBox.DataSource = _nv.GetAll();
            MaNV_ComboBox.DisplayMember = "Manv";
            MaNV_ComboBox.ValueMember = "Manv";
            MaNV_ComboBox.SelectedIndex = -1;
        }
        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trả_Sách m = new Trả_Sách(manv,mk);
            m.Show();
            this.Hide();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mượn_Sách m = new Mượn_Sách(manv,mk);
            m.Show();
            this.Hide();
        }

        private void Thoat_Btn_Click(object sender, EventArgs e)
        {
            TrangChu t = new TrangChu(manv,mk);
            t.Show();
            this.Hide();
        }
        public void LoadData(dynamic data)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 8;
            int stt = 1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã xử lý";
            dataGridView1.Columns[2].Name = "Mã phiếu trả";
            dataGridView1.Columns[3].Name = "Số thẻ";
            dataGridView1.Columns[4].Name = "Mã nhân viên";
            dataGridView1.Columns[5].Name = "Lý do";
            dataGridView1.Columns[6].Name = "Hình thức xử lý";
            dataGridView1.Columns[7].Name = "Ngày xử lý";
            foreach(var x in data)
            {
                dataGridView1.Rows.Add(stt++,x.Maxuly,x.Matra,x.Sothe,x.Manv,x.Lydovp,x.Htxuly,x.Ngayxl);
            }
            
        }
        private void Them_Btn_Click(object sender, EventArgs e)
        {
            bool a = _servie.Add(MaXL_Textbox.Text, new Xulyvp
            {
                Maxuly = MaXL_Textbox.Text,
                Matra = matra_combobox.Text,
                Sothe = MaDocGia_Combobox.Text,
                Manv = MaNV_ComboBox.Text,
                Lydovp = LyDoVP_Textbox.Text,
                Htxuly = comboBox1.Text,
                Ngayxl = NgayMuon_Date.Value
            });
            if(a)
            {
                LoadData(_servie.GetAll());
                ClearData();
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thông tin thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sua_Btn_Click(object sender, EventArgs e)
        {
            bool a = _servie.Update(MaXL_Textbox.Text, new Xulyvp
            {
                Matra = matra_combobox.Text,
                Sothe = MaDocGia_Combobox.Text,
                Manv = MaNV_ComboBox.Text,
                Lydovp = LyDoVP_Textbox.Text,
                Htxuly = comboBox1.Text,
                Ngayxl = NgayMuon_Date.Value
            });
            if (a)
            {
                LoadData(_servie.GetAll());
                ClearData();
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Xóa_btn_Click(object sender, EventArgs e)
        {
            bool a = _servie.Delete(MaXL_Textbox.Text);
            if (a)
            {
                LoadData(_servie.GetAll());
                ClearData();
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thông tin thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimKiemTen_Btn_Click(object sender, EventArgs e)
        {
            LoadData(_servie.GetById(TimKiemTen_Texbox.Text));
        }
        public void ClearData()
        {
            MaXL_Textbox.Text = LyDoVP_Textbox.Text = comboBox1.Text = "";
            MaDocGia_Combobox.SelectedIndex = MaNV_ComboBox.SelectedIndex = matra_combobox.SelectedIndex = -1;
            NgayMuon_Date.Value = DateTime.Now;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selected = dataGridView1.Rows[index];
            MaXL_Textbox.Text = selected.Cells[1].Value.ToString();
            MaDocGia_Combobox.SelectedValue = selected.Cells[2].Value;
            MaNV_ComboBox.SelectedValue = selected.Cells[3].Value;
            matra_combobox.SelectedValue = selected.Cells[4].Value;
            NgayMuon_Date.Value = (DateTime)selected.Cells[5].Value;
            LyDoVP_Textbox.Text = selected.Cells[6].Value.ToString();
            comboBox1.Text = selected.Cells[7].Value.ToString();
        }
    }
}
