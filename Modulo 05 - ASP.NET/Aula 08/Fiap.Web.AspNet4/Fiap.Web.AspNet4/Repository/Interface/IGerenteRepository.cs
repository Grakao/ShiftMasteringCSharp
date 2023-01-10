using Fiap.Web.AspNet4.Models;

namespace Fiap.Web.AspNet4.Repository.Interface
{
	public interface IGerenteRepository
	{
		public List<GerenteModel> FindAll();

		public GerenteModel FindById(int id);

		public void Insert(GerenteModel gerenteModel);

		public void Update(GerenteModel gerenteModel);

		public void Delete(GerenteModel gerenteModel);

		public void Delete(int id);
	}
}
