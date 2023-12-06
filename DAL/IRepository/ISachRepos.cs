using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface ISachRepos
    {
        bool AddSach(string id, Sach sach);
        bool DeleteSach(string masach);
        bool UpdateSach(string masach,Sach sach);
        List<Sach> GetAll();
        List<Sach> GetById(string id);
    }
}
