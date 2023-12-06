using DAL.IRepository;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class NhaXBRepos : INhaXBrepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public NhaXBRepos() { }

        public NhaXBRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool Add(string id,Nhaxuatban nxb)
        {
            var a = _context.Nhaxuatbans.FirstOrDefault(x => x.Manxb == id);
            if (a == null)
            {
                _context.Nhaxuatbans.Add(nxb);
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
            var xoa = _context.Nhaxuatbans.FirstOrDefault(x => x.Manxb == id);
            
            if(xoa != null)
            {
                _context.Nhaxuatbans.Remove(xoa);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Nhaxuatban> GetAll()
        {
            return _context.Nhaxuatbans.ToList();
        }

        public bool Update(string id, Nhaxuatban nxb)
        {
            var xoa = _context.Nhaxuatbans.FirstOrDefault(x => x.Manxb == id);
            
            if (xoa != null)
            {
                xoa.Tennxb = nxb.Tennxb;
                xoa.Ghichu = nxb.Ghichu;
                _context.Nhaxuatbans.Update(xoa);
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
