using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Docgia = new HashSet<Docgium>();
            Phieutras = new HashSet<Phieutra>();
            Xulyvps = new HashSet<Xulyvp>();
        }

        public string Manv { get; set; } = null!;
        public string Hoten { get; set; } = null!;
        public bool? Gioitinh { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string? Diachi { get; set; }
        public string? Sdt { get; set; }
        public string? Email { get; set; }
        public string? Cccd { get; set; }
        public string Password { get; set; } = null!;
        public string Chucdanh { get; set; } = null!;

        public virtual ICollection<Docgium> Docgia { get; set; }
        public virtual ICollection<Phieutra> Phieutras { get; set; }
        public virtual ICollection<Xulyvp> Xulyvps { get; set; }
    }
}
