using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Xulyvp
    {
        public string Maxuly { get; set; } = null!;
        public string Matra { get; set; } = null!;
        public string Sothe { get; set; } = null!;
        public string Manv { get; set; } = null!;
        public string? Lydovp { get; set; }
        public string? Htxuly { get; set; }
        public DateTime? Ngayxl { get; set; }

        public virtual Nhanvien ManvNavigation { get; set; } = null!;
        public virtual Phieutra MatraNavigation { get; set; } = null!;
        public virtual Docgium SotheNavigation { get; set; } = null!;
    }
}
