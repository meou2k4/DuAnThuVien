using DAL.IRepository;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class MuonSachRepos : IMuonSachRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();

        public MuonSachRepos() { }
        public MuonSachRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool AddMuonSach(string id, Phieumuon muon)
        {
            var a = _context.Phieumuons.FirstOrDefault(x => x.Mamuon == id);
            if (a == null)
            {
                _context.Phieumuons.Add(muon);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteMuonSach(string mamuon)
        {
            var a = _context.Phieumuons.FirstOrDefault(x => x.Mamuon == mamuon);
            var b = _context.Phieumuoncts.Where(x => x.Mamuon == mamuon);
            if (a != null)
            {
                _context.Phieumuoncts.RemoveRange(b);
                _context.Phieumuons.Remove(a);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Phieumuon> GetAll()
        {
            return _context.Phieumuons.ToList();
        }

        public List<Phieumuon> GetById(string id)
        {
            return _context.Phieumuons.Where(x => x.Mamuon == id).ToList();
        }

        public bool UpdateMuonSach(string id, Phieumuon muon)
        {
            var a = _context.Phieumuons.FirstOrDefault(x => x.Mamuon == id);
            if (a == null)
            {
                a.Sothe = muon.Sothe;
                a.Ngaymuon = muon.Ngaymuon;
                a.Hantra = muon.Hantra;
                a.Manv = muon.Manv;
                a.Trangthai = muon.Trangthai;
                _context.Phieumuons.Update(muon);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Phieumuon> QuaHan()
        {
            return _context.Phieumuons.Where(x => x.Hantra < DateTime.Today).ToList();
        }
    }
}
