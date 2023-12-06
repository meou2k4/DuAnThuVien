using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Phieutra
    {
        public Phieutra()
        {
            Phieutracts = new HashSet<Phieutract>();
            Xulyvps = new HashSet<Xulyvp>();
        }

        public string Matra { get; set; } = null!;
        public string Sothe { get; set; } = null!;
        public DateTime Ngaymuon { get; set; }
        public DateTime Hantra { get; set; }
        public DateTime Ngaytra { get; set; }
        public string Manv { get; set; } = null!;
        public string? Trangthai { get; set; }

        public virtual Nhanvien ManvNavigation { get; set; } = null!;
        public virtual Docgium SotheNavigation { get; set; } = null!;
        public virtual ICollection<Phieutract> Phieutracts { get; set; }
        public virtual ICollection<Xulyvp> Xulyvps { get; set; }
    }
}
