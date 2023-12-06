using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    internal interface IMuonSachService
    {
        bool AddMuonSach(string id, Phieumuon muon);
        bool DeleteMuonSach(string mamuon);
        bool UpdateMuonSach(string id, Phieumuon muon);
        List<Phieumuon> GetAll();
        List<Phieumuon> GetById(string id);
    }
}
