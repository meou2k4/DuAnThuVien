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
    public class TraSachCTRepos : ITraSachCTRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public TraSachCTRepos() { }

        public TraSachCTRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool Add(Phieutract ct, int sl, string masach)
        {
            var a = _context.Saches.FirstOrDefault(x => x.Masach == masach);
            a.Soluong += sl;
            _context.Phieutracts.Add(ct);
            _context.Saches.Update(a);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id, int sl, string masach)
        {
            var a = _context.Phieutracts.FirstOrDefault(x => x.Id == id);
            var b = _context.Saches.FirstOrDefault(x => x.Masach == masach);
            if (a != null)
            {
                b.Soluong -= sl;
                _context.Saches.Update(b);
                _context.Phieutracts.Remove(a);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Phieutract> GetByID(string id)
        {
            return _context.Phieutracts.Where(x => x.Matra == id).ToList();
        }

        public bool Update(int id, Phieutract ct, int sl, int s, string masach)
        {
            var a = _context.Phieutracts.FirstOrDefault(x => x.Id == id);
            var b = _context.Saches.FirstOrDefault(x => x.Masach == masach);
            if (a != null)
            {
                b.Soluong = b.Soluong -s + sl;
                _context.Saches.Update(b);
                _context.Phieutracts.Remove(a);
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
