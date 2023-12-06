using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface INgonNguRepos
    {
        List<Ngonngu> GetAll();
        List<Ngonngu> GetById(string id);
        bool Add(string id, Ngonngu tl);
        bool Update(string id, Ngonngu tl);
        bool Delete(string id);
    }
}
