using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    internal interface ITheLoaiService
    {
        List<Theloai> GetAll();
        List<Theloai> GetById(string id);
        bool Add(string id, Theloai tl);
        bool Update(string id,Theloai tl);
        bool Delete(string id);
    }
}
