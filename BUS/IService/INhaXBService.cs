using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    internal interface INhaXBService
    {
        List<Nhaxuatban> GetAll();
        bool Add(string id, Nhaxuatban nxb);
        bool Update(string id, Nhaxuatban nxb);
        bool Delete(string id);
    }
}
