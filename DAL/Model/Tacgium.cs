using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Tacgium
    {
        public Tacgium()
        {
            Sachchitiets = new HashSet<Sachchitiet>();
        }

        public string Matacgia { get; set; } = null!;
        public string Tentacgia { get; set; } = null!;
        public string? Ghichi { get; set; }

        public virtual ICollection<Sachchitiet> Sachchitiets { get; set; }
    }
}
