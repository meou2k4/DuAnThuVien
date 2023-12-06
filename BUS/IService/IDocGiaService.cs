using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    internal interface IDocGiaService
    {
        List<Docgium> GetAll();
        List<Docgium> GetById(string id);
        bool Add(string id, Docgium dg);
        bool Update(string id, Docgium dg);
        bool Delete(string id);
    }
}
