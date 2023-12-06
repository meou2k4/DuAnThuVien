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
    public class TraSachRepos : ITraSachRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public TraSachRepos() { }
        public TraSachRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool AddTraSach(string id, Phieutra tra)
        {
            var a = _context.Phieutras.FirstOrDefault(x => x.Matra == id);
            if (a == null)
            {
                _context.Phieutras.Add(tra);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteTraSach(string matra)
        {
            var b = _context.Phieutracts.Where(x => x.Matra == matra);
            var a = _context.Phieutras.FirstOrDefault(x => x.Matra == matra);
            if (a != null)
            {
                _context.Phieutracts.RemoveRange(b);
                _context.Phieutras.Remove(a);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Phieutra> GetAll()
        {
            return _context.Phieutras.ToList();
        }

        public List<Phieutra> GetById(string matra)
        {
            return _context.Phieutras.Where(x => x.Matra ==matra).ToList();
        }

        public List<Phieutra> QuaHan()
        {
            return _context.Phieutras.Where(x => x.Hantra > x.Ngaytra).ToList();
        }

        public bool UpdateTraSach(string matra, Phieutra tra)
        {
            var a = _context.Phieutras.FirstOrDefault(x => x.Matra == matra);
            if (a != null)
            {
                a.Sothe = tra.Sothe;
                a.Ngaymuon = tra.Ngaymuon;
                a.Hantra = tra.Hantra;
                a.Ngaytra = tra.Ngaytra;
                a.Manv = tra.Manv;
                a.Trangthai = tra.Trangthai;
                _context.Phieutras.Update(a);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

