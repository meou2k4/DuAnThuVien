using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Theloai
    {
        public Theloai()
        {
            Sachchitiets = new HashSet<Sachchitiet>();
        }

        public string Matheloai { get; set; } = null!;
        public string Tentheloai { get; set; } = null!;
        public string? Ghichu { get; set; }

        public virtual ICollection<Sachchitiet> Sachchitiets { get; set; }
    }
}
