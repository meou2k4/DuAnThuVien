using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Sach
    {
        public Sach()
        {
            Phieumuoncts = new HashSet<Phieumuonct>();
            Phieutracts = new HashSet<Phieutract>();
            Sachchitiets = new HashSet<Sachchitiet>();
        }

        public string Masach { get; set; } = null!;
        public string Tensach { get; set; } = null!;
        public int? Soluong { get; set; }
        public DateTime? Ngaycn { get; set; }
        public string Manxb { get; set; } = null!;
        public DateTime? Ngayxb { get; set; }
        public int? Sotrang { get; set; }
        public string? Trangthai { get; set; }

        public virtual Nhaxuatban ManxbNavigation { get; set; } = null!;
        public virtual ICollection<Phieumuonct> Phieumuoncts { get; set; }
        public virtual ICollection<Phieutract> Phieutracts { get; set; }
        public virtual ICollection<Sachchitiet> Sachchitiets { get; set; }
    }
}
