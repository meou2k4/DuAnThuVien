using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Phieutract
    {
        public int Id { get; set; }
        public string Matra { get; set; } = null!;
        public string Masach { get; set; } = null!;
        public int? Soluong { get; set; }

        public virtual Sach MasachNavigation { get; set; } = null!;
        public virtual Phieutra MatraNavigation { get; set; } = null!;
    }
}
