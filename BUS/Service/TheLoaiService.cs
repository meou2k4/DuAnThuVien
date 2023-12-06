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
    public class TheLoaiService : ITheLoaiService
    {
        TheLoaiRepos _repos = new TheLoaiRepos();
        public TheLoaiService() { }

        public TheLoaiService(TheLoaiRepos repos)
        {
            _repos = repos;
        }

        public bool Add(string id, Theloai tl)
        {
            return _repos.Add(id, tl);
        }

        public bool Delete(string id)
        {
            return _repos.Delete(id);
        }

        public List<Theloai> GetAll()
        {
            return _repos.GetAll();
        }

        public List<Theloai> GetById(string id)
        {
            return _repos.GetById(id);
        }

        public bool Update(string id, Theloai tl)
        {
            return _repos.Update(id, tl);
        }
    }
}
