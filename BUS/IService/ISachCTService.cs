using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    internal interface ISachCTService
    {
        bool AddSach(Sachchitiet sach);
        bool DeleteSach(string masach);
        bool DeleteSachAll(string masach);
        bool UpdateSach(int masach, Sachchitiet sach);
        List<Sachchitiet> GetAll();
        List<Sachchitiet> GetById(string id);
    }
}
