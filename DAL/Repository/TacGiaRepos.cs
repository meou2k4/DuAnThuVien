using DAL.IRepository;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class TacGiaRepos : ITacGiaRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public TacGiaRepos() { }

        public TacGiaRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool Add(string id,Tacgium tg)
        {
            
            var a = _context.Theloais.FirstOrDefault(x => x.Matheloai == id);
            if(a == null)
            {
                _context.Tacgia.Add(tg);
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
            var xoa = _context.Tacgia.FirstOrDefault(x => x.Matacgia ==  id);
            
            if(xoa != null)
            {
                _context.Tacgia.Remove(xoa);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Tacgium> GetAll()
        {
            return _context.Tacgia.ToList();
        }

        public bool Update(string id, Tacgium tg)
        {
            var xoa = _context.Tacgia.FirstOrDefault(x => x.Matacgia == id);
            
            if (xoa != null)
            {
                xoa.Tentacgia = tg.Tentacgia;
                xoa.Ghichi = tg.Ghichi;
                _context.Tacgia.Update(xoa);
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
