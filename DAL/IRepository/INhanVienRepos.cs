using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface INhanVienRepos
    {
        bool ChangePassword(string id, string pass, string newPassword);
        List<Nhanvien> GetAll();
        List<Nhanvien> GetById(string id);
        bool Add(string id, Nhanvien nv);
        bool Update(string id,Nhanvien nv);
        bool Delete(string id);
        bool GetAdmin(string id, string pass);
        Nhanvien GetNhanVien(string id, string pass);
        bool ForgetPass(string sdt, string newpass);
    }
}
