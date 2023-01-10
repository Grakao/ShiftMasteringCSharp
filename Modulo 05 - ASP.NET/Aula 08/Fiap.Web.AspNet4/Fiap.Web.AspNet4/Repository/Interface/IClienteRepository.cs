using Fiap.Web.AspNet4.Models;

namespace Fiap.Web.AspNet4.Repository.Interface
{
	public interface IClienteRepository
	{
		public List<ClienteModel> FindAll();

		public List<ClienteModel> FindAllOrderByNomeAsc();

		public List<ClienteModel> FindAllOrderByNomeDesc();

		public List<ClienteModel> FindByNome(string nomeParcial);

		public List<ClienteModel> FindByNomeAndEmail(string nomeParcial, string emailParcial);

		public List<ClienteModel> FindByNomeAndEmailAndRep(string nomeParcial, string emailParcial, int? repId);

		public ClienteModel FindById(int id);

		public void Insert(ClienteModel ClienteModel);

		public void Update(ClienteModel ClienteModel);

		public void Delete(ClienteModel ClienteModel);

		public void Delete(int id);
	}
}
