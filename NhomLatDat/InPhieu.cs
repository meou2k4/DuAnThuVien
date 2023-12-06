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
    public partial class InPhieu : Form
    {
        string user;
        string pass;
        public InPhieu(string username, string mk, string phieu)
        {
            InitializeComponent();
            user = username;
            pass = mk;
            xemtruoctxt.Text = phieu;
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            phieuintxt.Text = xemtruoctxt.Text;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Mượn_Sách m = new Mượn_Sách(user, pass);
            m.Show();
            this.Hide();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            TrangChu m = new TrangChu(user, pass);
            m.Show();
            this.Hide();
        }
    }
}
