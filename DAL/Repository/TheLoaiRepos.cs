using DAL.IRepository;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class TheLoaiRepos : ITheLoaiRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public TheLoaiRepos() { }

        public TheLoaiRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool Add(string id,Theloai tl)
        {
            
            var a = _context.Theloais.FirstOrDefault(x => x.Matheloai == id);
            if (a == null)
            {
                _context.Theloais.Add(tl);
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
            var xoa = _context.Theloais.FirstOrDefault(x => x.Matheloai == id);
            
            if(xoa != null)
            {
                _context.Theloais.Remove(xoa);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Theloai> GetAll()
        {
            return _context.Theloais.ToList();
        }

        public List<Theloai> GetById(string id)
        {
            return _context.Theloais.Where(x =>x.Matheloai == id).ToList();
        }

        public bool Update(string id, Theloai tl)
        {
            var sua = _context.Theloais.FirstOrDefault(x => x.Matheloai == id);
            
            if (sua != null)
            {
                sua.Tentheloai = tl.Tentheloai;
                sua.Ghichu = tl.Ghichu;
                _context.Theloais.Update(sua);
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
