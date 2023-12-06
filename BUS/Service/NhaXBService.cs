using BUS.IService;
using DAL.Model;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class NhaXBService : INhaXBService
    {
        NhaXBRepos _repos = new NhaXBRepos();
        public NhaXBService() { }

        public NhaXBService(NhaXBRepos repos)
        {
            _repos = repos;
        }

        public bool Add(string id, Nhaxuatban nxb)
        {
            return _repos.Add(id, nxb);
        }

        public bool Delete(string id)
        {
            return _repos.Delete(id);
        }

        public List<Nhaxuatban> GetAll()
        {
            return _repos.GetAll();
        }

        public bool Update(string id, Nhaxuatban nxb)
        {
            return _repos.Update(id, nxb);
        }
    }
}
