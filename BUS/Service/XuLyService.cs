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
    public class XuLyService : IXuLyService
    {
        XuLyRepos _repos = new XuLyRepos();
        public XuLyService() { }

        public XuLyService(XuLyRepos repos)
        {
            _repos = repos;
        }

        public bool Add(string id, Xulyvp xl)
        {
            return _repos.Add(id, xl);
        }

        public bool Delete(string id)
        {
            return _repos.Delete(id);
        }

        public List<Xulyvp> GetAll()
        {
            return _repos.GetAll();
        }

        public List<Phieutra> GetAllPhieutra()
        {
            return _repos.GetAllPhieutra();
        }

        public List<Xulyvp> GetById(string id)
        {
            return _repos.GetById(id);
        }

        public bool Update(string id, Xulyvp xl)
        {
            return _repos.Update(id, xl);
        }
    }
}
