using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface ISachCTRepos
    {
        bool AddSach(Sachchitiet sach);
        bool DeleteSach(string masach);
        bool DeleteSachAll(string masach);
        bool UpdateSach(int masach, Sachchitiet sach);
        List<Sachchitiet> GetAll();
        List<Sachchitiet> GetById(string id);
    }
}
