using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Ngonngu
    {
        public Ngonngu()
        {
            Sachchitiets = new HashSet<Sachchitiet>();
        }

        public string Mangonngu { get; set; } = null!;
        public string Tenngonngu { get; set; } = null!;
        public string? Ghichu { get; set; }

        public virtual ICollection<Sachchitiet> Sachchitiets { get; set; }
    }
}
