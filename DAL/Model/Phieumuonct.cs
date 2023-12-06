﻿using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Phieumuonct
    {
        public int Id { get; set; }
        public string Mamuon { get; set; } = null!;
        public string Masach { get; set; } = null!;
        public int? Soluong { get; set; }

        public virtual Phieumuon MamuonNavigation { get; set; } = null!;
        public virtual Sach MasachNavigation { get; set; } = null!;
    }
}
