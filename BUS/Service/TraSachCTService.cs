using BUS.IService;
using DAL.Model;
using DAL.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class TraSachCTService : ITraSachCTService
    {
        TraSachCTRepos _repos = new TraSachCTRepos();
        public TraSachCTService() { }

        public TraSachCTService(TraSachCTRepos repos)
        {
            _repos = repos;
        }

        public bool Add(Phieutract ct, int sl, string masach)
        {
            return _repos.Add(ct, sl, masach);
        }

        public bool Delete(int id, int sl, string masach)
        {
            return _repos.Delete(id, sl, masach);   
        }

        public List<Phieutract> GetByID(string id)
        {
            return _repos.GetByID(id);
        }

        public bool Update(int id, Phieutract ct, int sl, int s, string masach)
        {
            return _repos.Update(id, ct, sl, s, masach);
        }
    }
}
