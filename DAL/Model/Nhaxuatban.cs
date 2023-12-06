using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Nhaxuatban
    {
        public Nhaxuatban()
        {
            Saches = new HashSet<Sach>();
        }

        public string Manxb { get; set; } = null!;
        public string Tennxb { get; set; } = null!;
        public string? Ghichu { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
    }
}
