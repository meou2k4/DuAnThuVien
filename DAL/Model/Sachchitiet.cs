using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Sachchitiet
    {
        public int Id { get; set; }
        public string Masach { get; set; } = null!;
        public string Matacgia { get; set; } = null!;
        public string Matheloai { get; set; } = null!;
        public string Mangonngu { get; set; } = null!;

        public virtual Ngonngu MangonnguNavigation { get; set; } = null!;
        public virtual Sach MasachNavigation { get; set; } = null!;
        public virtual Tacgium MatacgiaNavigation { get; set; } = null!;
        public virtual Theloai MatheloaiNavigation { get; set; } = null!;
    }
}
