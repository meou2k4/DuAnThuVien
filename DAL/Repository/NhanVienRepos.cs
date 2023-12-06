using DAL.IRepository;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class NhanVienRepos : INhanVienRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public NhanVienRepos() { }

        public NhanVienRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool Add(string id,Nhanvien nv)
        {
            var a = _context.Nhanviens.FirstOrDefault(x => x.Manv == id);
            if (a == null)
            {
                _context.Nhanviens.Add(nv);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool ChangePassword(string id, string pass,string newPassword)
        {
            var nhanVien = _context.Nhanviens.FirstOrDefault(x => x.Manv == id && x.Password == pass);
            if (nhanVien != null)
            {
                nhanVien.Password = newPassword;
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
            var xoa = _context.Nhanviens.FirstOrDefault(x => x.Manv == id);
            
            if (xoa != null)
            {
                _context.Nhanviens.Remove(xoa);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ForgetPass(string sdt, string newpass)
        {
            var a = _context.Nhanviens.FirstOrDefault(x => x.Sdt == sdt);
            if (a != null)
            {
                a.Password = newpass;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool GetAdmin(string id, string pass)
        {
            var a = _context.Nhanviens.FirstOrDefault(x => x.Manv == id && x.Password == pass && x.Chucdanh == "Admin");
            if(a != null)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public List<Nhanvien> GetAll()
        {
            return _context.Nhanviens.ToList();
        }

        public List<Nhanvien> GetById(string id)
        {
            return _context.Nhanviens.Where(x => x.Manv == id).ToList();
        }


        public Nhanvien GetNhanVien(string id, string pass)
        {
            return _context.Nhanviens.FirstOrDefault(x => x.Manv == id && x.Password == pass);
        }

        public bool Update(string id, Nhanvien nv)
        {
            var xoa = _context.Nhanviens.FirstOrDefault(x => x.Manv == id);
            
            if (xoa != null)
            {
                xoa.Hoten = nv.Hoten;
                xoa.Gioitinh = nv.Gioitinh;
                xoa.Ngaysinh = nv.Ngaysinh;
                xoa.Diachi = nv.Diachi;
                xoa.Cccd = nv.Cccd;
                xoa.Sdt = nv.Sdt;
                xoa.Email = nv.Email;
                xoa.Password = nv.Password;
                xoa.Chucdanh = nv.Chucdanh;
                _context.Nhanviens.Update(xoa);
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
