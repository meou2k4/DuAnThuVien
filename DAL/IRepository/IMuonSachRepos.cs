using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface IMuonSachRepos
    {
        bool AddMuonSach(string id, Phieumuon muon);
        bool DeleteMuonSach(string mamuon);
        bool UpdateMuonSach(string id, Phieumuon muon);
        List<Phieumuon> GetAll();
        List<Phieumuon> GetById(string id);
    }
}

