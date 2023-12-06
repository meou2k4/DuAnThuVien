using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    internal interface ITacGiaService
    {
        List<Tacgium> GetAll();
        bool Add(string id, Tacgium tg);
        bool Update(string id, Tacgium tg);
        bool Delete(string id);
    }
}
