using DAL.IRepository;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class NgonNguRepos : INgonNguRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public NgonNguRepos() { }

        public NgonNguRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool Add(string id,Ngonngu tl)
        {
            if(_context.Ngonngus.FirstOrDefault(x=>x.Mangonngu ==id) == null)
            {
                _context.Ngonngus.Add(tl);
                _context.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public bool Delete(string id)
        {
            var xoa = _context.Ngonngus.FirstOrDefault(x => x.Mangonngu == id);
            
            if (xoa != null)
            {
                _context.Ngonngus.Remove(xoa);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Ngonngu> GetAll()
        {
            return _context.Ngonngus.ToList();
        }

        public List<Ngonngu> GetById(string id)
        {
            return _context.Ngonngus.Where(x => x.Mangonngu == id).ToList();
        }

        public bool Update(string id, Ngonngu tl)
        {
            var xoa = _context.Ngonngus.FirstOrDefault(x => x.Mangonngu == id);
            
            if (xoa != null)
            {
                xoa.Tenngonngu = tl.Tenngonngu;
                xoa.Ghichu = tl.Ghichu;
                _context.Ngonngus.Update(xoa);
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
