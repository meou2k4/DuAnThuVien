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
    public class MuonSachCTService : IMuonSachCTService
    {
        MuonSachCTRepos _repos = new MuonSachCTRepos();
        public MuonSachCTService() { }

        public MuonSachCTService(MuonSachCTRepos repos)
        {
            _repos = repos;
        }
        public bool Add(Phieumuonct ct, int sl, string masach)
        {
            return _repos.Add(ct,sl,masach);
        }
        public bool Delete(int id, int sl, string masach)
        {
            return _repos.Delete(id, sl, masach);
        }

        public List<Phieumuonct> GetAll()
        {
            return _repos.GetAll();
        }

        public List<Phieumuonct> GetById(string id)
        {
            return _repos.GetById(id);
        }

        public bool Update(int id, Phieumuonct ct, int sl, int s, string masach)
        {
            return _repos.Update(id, ct,sl,s,masach);
        }
    }
}
