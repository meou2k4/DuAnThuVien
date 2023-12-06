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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NhomLatDat
{
    public partial class Quản_Lý_Ngôn_Ngữ : Form
    {
        string user;
        string mk;
        NgonNguService _service = new NgonNguService();
        public Quản_Lý_Ngôn_Ngữ(string user, string mk)
        {
            InitializeComponent();
            ClearData();
            LoadData(_service.GetAll());
            this.user = user;
            this.mk = mk;
        }
        public void ClearData()
        {
            MaNgonNgu_Texbox.Text = "";
            NgonNgu_Texbox.Text = "";
            GhiChu_TexBox.Text = "";
        }
        public void LoadData(dynamic data)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 4;
            int stt = 1;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã ngôn ngữ";
            dataGridView1.Columns[2].Name = "Ngôn ngữ";
            dataGridView1.Columns[3].Name = "Ghi chú";
            foreach (var x in data)
            {
                dataGridView1.Rows.Add(stt++, x.Mangonngu, x.Tenngonngu, x.Ghichu);
            }
        }
        private void Them_Btn_Click(object sender, EventArgs e)
        {
                var add = _service.Add(MaNgonNgu_Texbox.Text, new DAL.Model.Ngonngu
                {
                    Mangonngu = MaNgonNgu_Texbox.Text,
                    Tenngonngu = NgonNgu_Texbox.Text,
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
                var add = _service.Update(MaNgonNgu_Texbox.Text, new DAL.Model.Ngonngu
                {
                    Tenngonngu = NgonNgu_Texbox.Text,
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

        private void Xoa_Btn_Click(object sender, EventArgs e)
        {
            var add = _service.Delete(MaNgonNgu_Texbox.Text);
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
            MaNgonNgu_Texbox.Text = selected.Cells[1].Value.ToString();
            NgonNgu_Texbox.Text = selected.Cells[2].Value.ToString();
            GhiChu_TexBox.Text = selected.Cells[3].Value.ToString();
        }
    }
}
