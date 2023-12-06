using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Docgium
    {
        public Docgium()
        {
            Phieumuons = new HashSet<Phieumuon>();
            Phieutras = new HashSet<Phieutra>();
            Xulyvps = new HashSet<Xulyvp>();
        }

        public string Sothe { get; set; } = null!;
        public string Hoten { get; set; } = null!;
        public bool? Gioitinh { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string? Diachi { get; set; }
        public string? Sdt { get; set; }
        public string? Email { get; set; }
        public string? Cccd { get; set; }
        public string Manv { get; set; } = null!;
        public DateTime? Ngaycap { get; set; }
        public DateTime? Ngayhethan { get; set; }

        public virtual Nhanvien ManvNavigation { get; set; } = null!;
        public virtual ICollection<Phieumuon> Phieumuons { get; set; }
        public virtual ICollection<Phieutra> Phieutras { get; set; }
        public virtual ICollection<Xulyvp> Xulyvps { get; set; }
    }
}
