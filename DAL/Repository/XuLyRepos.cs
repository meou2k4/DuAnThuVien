using DAL.IRepository;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class XuLyRepos : IXuLyRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public XuLyRepos() { }

        public XuLyRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool Add(string id, Xulyvp xl)
        {
            var b = _context.Phieutras.FirstOrDefault(x => x.Matra == xl.Matra);
            var a = _context.Xulyvps.FirstOrDefault(x => x.Maxuly == id);
            if(a == null)
            {
                b.Trangthai = "Trả quá hạn";
                _context.Phieutras.Update(b);
                _context.Xulyvps.Add(xl);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(string id)
        {
            var a = _context.Xulyvps.FirstOrDefault(x => x.Maxuly == id);
            if (a != null)
            {
                _context.Xulyvps.Remove(a);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Xulyvp> GetAll()
        {
            return _context.Xulyvps.ToList();
        }

        public List<Phieutra> GetAllPhieutra()
        {
            return _context.Phieutras.Where(x => x.Ngaytra > x.Hantra).ToList();
        }

        public List<Xulyvp> GetById(string id)
        {
            return _context.Xulyvps.Where(x=>x.Maxuly ==id).ToList();
        }

        public bool Update(string id, Xulyvp xl)
        {
            var a = _context.Xulyvps.FirstOrDefault(x => x.Maxuly == id);
            if (a != null)
            {
                a.Matra = xl.Matra;
                a.Sothe = xl.Sothe;
                a.Manv = xl.Manv;
                a.Lydovp = xl.Lydovp;
                a.Htxuly = xl.Htxuly;
                a.Ngayxl = xl.Ngayxl;
                _context.Xulyvps.Update(a);
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
