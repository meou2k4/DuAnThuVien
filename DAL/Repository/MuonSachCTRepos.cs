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
    public class MuonSachCTRepos : IMuonSachCTRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public MuonSachCTRepos() { }

        public MuonSachCTRepos(QLTHUVIENContext context)
        {
            _context = context;
        }


        public bool Add(Phieumuonct ct, int sl, string masach)
        {
            var a = _context.Saches.FirstOrDefault(x => x.Masach == masach);
            if (a.Soluong > sl)
            {
                a.Soluong -= sl;
                _context.Phieumuoncts.Add(ct);
                _context.Saches.Update(a);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete(int id, int sl, string masach)
        {
            var b = _context.Saches.FirstOrDefault(x => x.Masach == masach);
            var a = _context.Phieumuoncts.FirstOrDefault(x => x.Id == id);
            
            if (b.Soluong > sl)
            {
                if (a != null)
                {
                    b.Soluong = b.Soluong + sl;
                    _context.Saches.Update(b);
                    _context.Phieumuoncts.Remove(a);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public List<Phieumuonct> GetAll()
        {
            return _context.Phieumuoncts.ToList();
        }

        public List<Phieumuonct> GetById(string id)
        {
            return _context.Phieumuoncts.Where(x => x.Mamuon == id).ToList();
        }

        public bool Update(int id, Phieumuonct ct,int sl,int s, string masach)
        {
            var a = _context.Phieumuoncts.FirstOrDefault(x => x.Id == id);
            var b = _context.Saches.FirstOrDefault(x =>x.Masach == masach);
            
            if(b.Soluong>sl)
            {
                if (a != null)
                {
                    a.Masach = ct.Masach;
                    a.Soluong = ct.Soluong;
                    b.Soluong = b.Soluong + s - sl;
                    _context.Saches.Update(b);
                    _context.Phieumuoncts.Update(a);

                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
       
    }
}
