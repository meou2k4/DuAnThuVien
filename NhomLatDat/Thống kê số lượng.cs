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
    
    public partial class Thống_kê_số_lượng : Form
    {
        string username;
        string mk;
        SachService _service = new SachService();
        public Thống_kê_số_lượng(string username, string mk)
        {
            InitializeComponent();
            this.username = username;
            int sl = 0;
            
            foreach (var x in _service.GetAll())
            {
                sl += (int)x.Soluong;
            }
            txtsoluong.Text = sl.ToString();
            int s;
            s = _service.GetAll().Count;
            txttongsach.Text = s.ToString();
            this.mk = mk;
            LoadData();
        }
        public void LoadData()
        {
            view.Rows.Clear();
            view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            view.ColumnCount = 4;
            view.Columns[0].Name = "STT";
            view.Columns[1].Name = "Mã Sách";
            view.Columns[2].Name = "Tên Sách";
            view.Columns[3].Name = "Số lượng";
            int stt = 1;
            foreach (var x in _service.GetAll())
            {
                view.Rows.Add(stt++,x.Masach,x.Tensach,x.Soluong);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TrangChu a = new TrangChu(username,mk);
            a.Show();
            this.Hide();
        }
    }
}
