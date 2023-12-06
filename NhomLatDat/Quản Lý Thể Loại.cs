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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NhomLatDat
{
    public partial class Quản_Lý_Thể_Loại : Form
    {
        TheLoaiService _service = new TheLoaiService();
        string user;
        string mk;
        public Quản_Lý_Thể_Loại(string user, string mk)
        {
            InitializeComponent();
            LoadData(_service.GetAll());
            ClearData();
            this.user = user;
            this.mk = mk;
        }
        public void LoadData(dynamic data)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 4;
            int stt = 1;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã thể loại";
            dataGridView1.Columns[2].Name = "Tên thể loại";
            dataGridView1.Columns[3].Name = "Ghi chú";
            foreach (var x in data)
            {
                dataGridView1.Rows.Add(stt++, x.Matheloai, x.Tentheloai, x.Ghichu);
            }
        }
        private void Them_Btn_Click(object sender, EventArgs e)
        {
            var add = _service.Add(MaTheLoai_Texbox.Text, new DAL.Model.Theloai
            {
                Matheloai = MaTheLoai_Texbox.Text,
                Tentheloai = TenTheLoai_Texbox.Text,
                Ghichu = GhiChu_TexBox.Text
            });
            if (add)
            {
                LoadData(_service.GetAll());
                ClearData();
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thông tin thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ClearData()
        {
            MaTheLoai_Texbox.Text = "";
            TenTheLoai_Texbox.Text = "";
            GhiChu_TexBox.Text = "";
        }
        private void Sua_Btn_Click(object sender, EventArgs e)
        {
            var add = _service.Update(MaTheLoai_Texbox.Text, new DAL.Model.Theloai
            {
                Tentheloai = TenTheLoai_Texbox.Text,
                Ghichu = GhiChu_TexBox.Text
            });
            if (add)
            {
                LoadData(_service.GetAll());
                ClearData();
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Xoa_Btn_Click(object sender, EventArgs e)
        {
            var add = _service.Delete(MaTheLoai_Texbox.Text);
            if (add)
            {
                LoadData(_service.GetAll());
                ClearData();
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thông tin thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Thoat_Btn_Click(object sender, EventArgs e)
        {
            TrangChu menu = new TrangChu(user,mk);
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
            MaTheLoai_Texbox.Text = selected.Cells[1].Value.ToString();
            TenTheLoai_Texbox.Text = selected.Cells[2].Value.ToString();
            GhiChu_TexBox.Text = selected.Cells[3].Value.ToString();
        }
    }
}
