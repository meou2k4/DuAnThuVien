using DAL.IRepository;
using DAL.Model;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;

namespace DAL.Repository
{
    public class SachRepos : ISachRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public SachRepos() { }

        public SachRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool AddSach(string id, Sach sach)
        {
            var a = _context.Saches.FirstOrDefault(x => x.Masach == id);
            if (sach.Soluong > 0)
            {
                if (a == null)
                {
                    _context.Saches.Add(sach);
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

        public bool DeleteSach(string masach)
        {
            var a = _context.Saches.FirstOrDefault(x => x.Masach == masach);
            if (a != null)
            {
                _context.Saches.Remove(a);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Sach> GetAll()
        {
            return _context.Saches.ToList();
        }

        public List<Sach> GetById(string id)
        {
            return _context.Saches.Where(x => x.Masach == id).ToList();
        }

        public bool UpdateSach(string masach, Sach sach)
        {
            var a = _context.Saches.FirstOrDefault(x => x.Masach == masach);
            
            if (sach.Soluong > 0)
            {
                if (a != null)
                {
                    a.Tensach = sach.Tensach;
                    a.Soluong = sach.Soluong;
                    a.Ngaycn = sach.Ngaycn;
                    a.Trangthai = sach.Trangthai;
                    _context.Saches.Update(a);
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
