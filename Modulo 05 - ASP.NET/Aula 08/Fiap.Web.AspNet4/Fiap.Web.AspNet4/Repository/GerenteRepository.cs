using Fiap.Web.AspNet4.Data;
using Fiap.Web.AspNet4.Models;
using Fiap.Web.AspNet4.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.AspNet4.Repository
{
    public class GerenteRepository : IGerenteRepository
    {
        private readonly DataContext dataContext;

        public GerenteRepository(DataContext context)
        {
            dataContext = context;
        }

        public List<GerenteModel> FindAll()
        {
            //return dataContext.Clientes.ToList<GerenteModel>();

            return dataContext
                .Gerentes // SELECT * FROM GERENTE
                .ToList<GerenteModel>();
        }

        public GerenteModel FindById(int id)
        {
            //return dataContext.Clientes.Find(id);

            var gerenteModel = dataContext.Gerentes // SELECT * FROM GERENTE
                .SingleOrDefault(g => g.GerenteId == id); // Where

            return gerenteModel;
        }

        public void Insert(GerenteModel gerenteModel)
        {
            dataContext.Gerentes.Add(gerenteModel);
            dataContext.SaveChanges();
        }

        public void Update(GerenteModel gerenteModel)
        {
            dataContext.Gerentes.Update(gerenteModel);
            dataContext.SaveChanges();
        }

        public void Delete(GerenteModel gerenteModel)
        {
            dataContext.Gerentes.Remove(gerenteModel);
            dataContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var gerente = new GerenteModel();
            gerente.GerenteId = id;
            Delete(gerente);
        }
    }
}
