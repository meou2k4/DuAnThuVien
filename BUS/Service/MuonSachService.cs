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
    public class MuonSachService : IMuonSachService
    {
        MuonSachRepos _repos = new MuonSachRepos();
        public MuonSachService() { }
        public MuonSachService(MuonSachRepos repos)
        {
            _repos = repos;
        }

        public bool AddMuonSach(string id, Phieumuon muon)
        {
            return _repos.AddMuonSach(id,muon);
        }

        public bool DeleteMuonSach(string mamuon)
        {
            return _repos.DeleteMuonSach(mamuon);
        }

        public List<Phieumuon> GetAll()
        {
            return _repos.GetAll();
        }

        public List<Phieumuon> GetById(string id)
        {
            return _repos.GetById(id);
        }

        public bool UpdateMuonSach(string id, Phieumuon muon)
        {
            return _repos.UpdateMuonSach(id, muon);
        }
        public List<Phieumuon> QuaHan()
        {
            return _repos.QuaHan();
        }
    }
}
