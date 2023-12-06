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
    public class NgonNguService : INgonNguService
    {
        NgonNguRepos _repos = new NgonNguRepos();
        public NgonNguService()
        {

        }

        public NgonNguService(NgonNguRepos repos)
        {
            _repos = repos;
        }

        public bool Add(string id, Ngonngu tl)
        {
            return _repos.Add(id, tl);
        }

        public bool Delete(string id)
        {
            return (_repos.Delete(id)); 
        }

        public List<Ngonngu> GetAll()
        {
            return _repos.GetAll();
        }

        public List<Ngonngu> GetById(string id)
        {
            return _repos.GetById(id);
        }

        public bool Update(string id, Ngonngu tl)
        {
            return _repos.Update(id, tl);
        }
    }
}
