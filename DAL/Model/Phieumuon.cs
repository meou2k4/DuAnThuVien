using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Phieumuon
    {
        public Phieumuon()
        {
            Phieumuoncts = new HashSet<Phieumuonct>();
        }

        public string Mamuon { get; set; } = null!;
        public string Sothe { get; set; } = null!;
        public DateTime Ngaymuon { get; set; }
        public DateTime Hantra { get; set; }
        public string Manv { get; set; } = null!;
        public string? Trangthai { get; set; }

        public virtual Docgium SotheNavigation { get; set; } = null!;
        public virtual ICollection<Phieumuonct> Phieumuoncts { get; set; }
    }
}
