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
    public class SachCTService : ISachCTService
    {
        SachCTRepos _repos = new SachCTRepos();
        public SachCTService() { }

        public SachCTService(SachCTRepos repos)
        {
            _repos = repos;
        }

        public bool AddSach(Sachchitiet sach)
        {
            return _repos.AddSach(sach);
        }

        public bool DeleteSach(string masach)
        {
            return _repos.DeleteSach(masach);
        }

        public bool DeleteSachAll(string masach)
        {
            return _repos.DeleteSach(masach);
        }

        public List<Sachchitiet> GetAll()
        {
            return _repos.GetAll();
        }

        public List<Sachchitiet> GetById(string id)
        {
            return _repos.GetById(id);
        }

        public bool UpdateSach(int masach, Sachchitiet sach)
        {
            return _repos.UpdateSach(masach, sach);
        }
    }
}
