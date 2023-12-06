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
    public class TacGiaService : ITacGiaService
    {
        TacGiaRepos _repos = new TacGiaRepos();
        public TacGiaService() { }

        public TacGiaService(TacGiaRepos repos)
        {
            _repos = repos;
        }

        public bool Add(string id, Tacgium tg)
        {
            return _repos.Add(id, tg);
        }

        public bool Delete(string id)
        {
            return _repos.Delete(id);
        }

        public List<Tacgium> GetAll()
        {
            return _repos.GetAll();
        }

        public bool Update(string id, Tacgium tg)
        {
            return _repos.Update(id, tg);
        }
    }
}
