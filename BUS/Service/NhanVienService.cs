using BUS.IService;
using DAL.Model;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class NhanVienService : INhanVienService
    {
        NhanVienRepos _repos = new NhanVienRepos();
        public NhanVienService() { }

        public NhanVienService(NhanVienRepos repos)
        {
            _repos = repos;
        }

        public bool Add(string id, Nhanvien nv)
        {
            return _repos.Add(id, nv);
        }

        public bool ChangePassword(string id, string pass, string newPassword)
        {
            return _repos.ChangePassword(id, pass, newPassword);
        }

        public bool Delete(string id)
        {
            return _repos.Delete(id);
        }

        public bool ForgetPass(string sdt, string newpass)
        {
            return _repos.ForgetPass(sdt, newpass);
        }

        public bool GetAdmin(string id, string pass)
        {
            return _repos.GetAdmin(id, pass); 
        }

        public List<Nhanvien> GetAll()
        {
            return _repos.GetAll();
        }

        public List<Nhanvien> GetById(string id)
        {
            return _repos.GetById(id);
        }


        public Nhanvien GetNhanVien(string id, string pass)
        {
            return _repos.GetNhanVien(id, pass);
        }

        public bool Update(string id, Nhanvien nv)
        {
            return _repos.Update(id, nv);
        }
    }
}
