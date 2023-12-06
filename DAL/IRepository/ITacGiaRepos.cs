using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface ITacGiaRepos
    {
        List<Tacgium> GetAll();
        bool Add(string id, Tacgium tg);
        bool Update(string id,Tacgium tg);
        bool Delete(string id);
    }
}
