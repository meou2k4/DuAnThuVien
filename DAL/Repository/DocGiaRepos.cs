using DAL.IRepository;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class DocGiaRepos : IDocGiaRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public DocGiaRepos() { }

        public DocGiaRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool Add(string id,Docgium dg)
        {
            if(_context.Docgia.FirstOrDefault(x=>x.Sothe == id) == null)
            {
                _context.Docgia.Add(dg);
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
            var xoa = _context.Docgia.FirstOrDefault(x => x.Sothe == id);
            if (xoa != null)
            {
                _context.Docgia.Remove(xoa);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Docgium> GetAll()
        {
            return _context.Docgia.ToList();
        }

        public List<Docgium> GetById(string id)
        {
            return _context.Docgia.Where(x => x.Sothe == id).ToList();
        }

        public bool Update(string id, Docgium dg)
        {
            var xoa = _context.Docgia.FirstOrDefault(x => x.Sothe == id);
            if (xoa != null)
            {
                xoa.Hoten = dg.Hoten;
                xoa.Gioitinh = dg.Gioitinh;
                xoa.Ngaysinh = dg.Ngaysinh;
                xoa.Diachi = dg.Diachi;
                xoa.Sdt = dg.Sdt;
                xoa.Email = dg.Email;
                xoa.Cccd = dg.Cccd;
                xoa.Manv = dg.Manv;xoa.Ngaycap = dg.Ngaycap;
                xoa.Ngayhethan = dg.Ngayhethan;
                _context.Docgia.Update(xoa);
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
