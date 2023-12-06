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
    public partial class Quản_Lý_Nhà_Xuất_Bản : Form
    {
        NhaXBService _service = new NhaXBService();
        string user;
        string mk;
        public Quản_Lý_Nhà_Xuất_Bản(string user, string mk)
        {
            InitializeComponent();
            LoadData(_service.GetAll());
            ClearData();
            this.user = user;
            this.mk = mk;
        }
        public void ClearData()
        {
            MaNXB_Texbox.Text = "";
            NhaXB_Texbox.Text = "";
            GhiChu_TexBox.Text = "";
        }
        public void LoadData(dynamic data)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 4;
            int stt = 1;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã nhà xuất bản";
            dataGridView1.Columns[2].Name = "Tên nhà xuất bản";
            dataGridView1.Columns[3].Name = "Ghi chú";
            foreach (var x in data)
            {
                dataGridView1.Rows.Add(stt++, x.Manxb, x.Tennxb, x.Ghichu);
            }
        }
        private void Them_Btn_Click(object sender, EventArgs e)
        {
            bool add = _service.Add(MaNXB_Texbox.Text, new DAL.Model.Nhaxuatban
            {
                Manxb = MaNXB_Texbox.Text,
                Tennxb = NhaXB_Texbox.Text,
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

        private void Sua_Btn_Click(object sender, EventArgs e)
        {
            
                bool add = _service.Update(MaNXB_Texbox.Text, new DAL.Model.Nhaxuatban
                {
                    Tennxb = NhaXB_Texbox.Text,
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
            
                bool add = _service.Delete(MaNXB_Texbox.Text);
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
            TrangChu menu = new TrangChu(user, mk);
            menu.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selected = dataGridView1.Rows[index];
            MaNXB_Texbox.Text = selected.Cells[1].Value.ToString();
            NhaXB_Texbox.Text = selected.Cells[2].Value.ToString();
            GhiChu_TexBox.Text = selected.Cells[3].Value.ToString();
        }
    }
}
