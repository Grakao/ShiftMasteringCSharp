using Fiap.Web.AspNet4.Data;
using Fiap.Web.AspNet4.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.AspNet4.Repository
{
    public class ClienteRepository
    {
        private readonly DataContext dataContext;

        public ClienteRepository(DataContext context)
        {
            dataContext = context;
        }

        public List<ClienteModel> FindAll()
        {
            //return dataContext.Clientes.ToList<ClienteModel>();

            return dataContext
                .Clientes // SELECT * FROM CLIENTES
                .Include(r => r.Representante) // INNER JOIN
                .OrderBy(c => c.Nome)
                .ToList<ClienteModel>();
        }

        public ClienteModel FindById(int id)
        {
            //return dataContext.Clientes.Find(id);

            var clienteModel = dataContext.Clientes // SELECT * FROM CLIENTES
                .Include(r => r.Representante) // INNER JOIN
                .SingleOrDefault(c => c.ClienteId == id); // Where

            //dataContext
            //    .Clientes // select * from clientes
            //    .Find(id); // Where id = parametro do método

            //dataContext
            //    .Clientes // select * from clientes
            //    .SingleOrDefault(c => c.Observacao == null); // where observacao is null

            return clienteModel;
        }

        public void Insert(ClienteModel ClienteModel)
        {
            dataContext.Clientes.Add(ClienteModel);
            dataContext.SaveChanges();
        }

        public void Update(ClienteModel ClienteModel)
        {
            dataContext.Clientes.Update(ClienteModel);
            dataContext.SaveChanges();
        }

        public void Delete(ClienteModel ClienteModel)
        {
            dataContext.Clientes.Remove(ClienteModel);
            dataContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var Cliente = new ClienteModel();
            Cliente.ClienteId = id;
            Delete(Cliente);
        }
    }
}
