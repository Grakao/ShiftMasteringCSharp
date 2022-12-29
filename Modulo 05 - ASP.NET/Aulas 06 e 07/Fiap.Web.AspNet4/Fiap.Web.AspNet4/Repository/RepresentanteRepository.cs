using Fiap.Web.AspNet4.Data;
using Fiap.Web.AspNet4.Models;

namespace Fiap.Web.AspNet4.Repository
{
    public class RepresentanteRepository
    {
        private readonly DataContext dataContext;

        public RepresentanteRepository(DataContext context)
        {
            dataContext = context;
        }

        public List<RepresentanteModel> FindAll()
        {
            return dataContext.Representantes.ToList<RepresentanteModel>();
        }

        public RepresentanteModel FindById(int id)
        {
            return dataContext.Representantes.Find(id);
        }

        public void Insert(RepresentanteModel representanteModel)
        {
            dataContext.Representantes.Add(representanteModel);
            dataContext.SaveChanges();
        }

        public void Update(RepresentanteModel representanteModel)
        {
            dataContext.Representantes.Update(representanteModel);
            dataContext.SaveChanges();
        }

        public void Delete(RepresentanteModel representanteModel)
        {
            dataContext.Representantes.Remove(representanteModel);
            dataContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var representante = new RepresentanteModel();
            representante.RepresentanteId = id;
            Delete(representante);
        }
    }
}
