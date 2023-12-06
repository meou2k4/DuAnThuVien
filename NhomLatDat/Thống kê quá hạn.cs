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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NhomLatDat
{
    public partial class Thống_kê_quá_hạn : Form
    {
        string mk;
        MuonSachService _service = new MuonSachService();
        string username;
        public Thống_kê_quá_hạn(string username, string mk)
        {
            InitializeComponent();
            int rowCount = view.RowCount;
            txtsoluong.Text = rowCount.ToString();
            this.username = username;
            LoadData();
        }
        public void LoadData()
        {
            view.Rows.Clear();
            view.ColumnCount = 7;
            int stt = 1;
            view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            view.Columns[0].Name = "STT";
            view.Columns[1].Name = "Mã phiếu";
            view.Columns[2].Name = "Mã độc giả";
            view.Columns[3].Name = "Mã nhân viên";
            view.Columns[4].Name = "Ngày mượn";
            view.Columns[5].Name = "Hạn trả";
            view.Columns[6].Name = "Trạng thái";
            foreach (var x in _service.QuaHan())
            {
                view.Rows.Add(stt++, x.Mamuon, x.Sothe, x.Manv, x.Ngaymuon, x.Hantra, x.Trangthai);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TrangChu t = new TrangChu(username, mk);
            t.Show();
            this.Hide();
        }

        private void view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Xử_Lý_Vi_Phạm xl = new Xử_Lý_Vi_Phạm(username, mk);
            xl.Show();
            this.Hide();
        }

        private void Thống_kê_quá_hạn_Load(object sender, EventArgs e)
        {

        }
    }
}
