using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    internal interface ITraSachCTService
    {
        bool Add(Phieutract ct, int sl, string masach);
        bool Delete(int id, int sl, string masach);
        List<Phieutract> GetByID(string id);
        bool Update(int id, Phieutract ct, int sl, int s, string masach);
    }
}
