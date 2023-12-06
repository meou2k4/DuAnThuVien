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
    public class DocGiaService : IDocGiaService
    {
        DocGiaRepos _repos = new DocGiaRepos();
        public DocGiaService() { }

        public DocGiaService(DocGiaRepos repos)
        {
            _repos = repos;
        }

        public bool Add(string id, Docgium dg)
        {
            return _repos.Add(id,dg);
        }

        public bool Delete(string id)
        {
            return _repos.Delete(id);
        }

        public List<Docgium> GetAll()
        {
            return _repos.GetAll();
        }

        public List<Docgium> GetById(string id)
        {
            return _repos.GetById(id);
        }

        public bool Update(string id, Docgium dg)
        {
            return _repos.Update(id, dg);
        }
    }
}
