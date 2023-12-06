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
    public class SachCTRepos : ISachCTRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public SachCTRepos() { }

        public SachCTRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool AddSach(Sachchitiet sach)
        {
                _context.Sachchitiets.Add(sach);
                _context.SaveChanges();
                return true;
        }

        public bool DeleteSach(string masach)
        {
            var a = _context.Sachchitiets.FirstOrDefault(x => x.Masach == masach);
            if (a != null)
            {
                _context.Sachchitiets.Remove(a);
                _context.SaveChanges();
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        public bool DeleteSachAll(string masach)
        {
            var a = _context.Sachchitiets.FirstOrDefault(x => x.Masach == masach);
            if (a != null)
            {     
                _context.Sachchitiets.Remove(a);
            _context.SaveChanges();
            return true;
            }
            else
            {
                return false;
            }
        }

        public List<Sachchitiet> GetAll()
        {
            return _context.Sachchitiets.ToList();
        }

        public List<Sachchitiet> GetById(string id)
        {
            return _context.Sachchitiets.Where(x => x.Masach == id).ToList();
        }

        public bool UpdateSach(int masach, Sachchitiet sach)
        {
            var a = _context.Sachchitiets.FirstOrDefault(x => x.Id == masach);
            if (a != null)
            {
                a.Matacgia = sach.Matacgia;
                a.Mangonngu = sach.Mangonngu;
                a.Matheloai = sach.Matheloai;
                _context.Sachchitiets.Update(a);
                _context.SaveChanges();
                return true;
            }
            else { return false; }
        }
    }
}
