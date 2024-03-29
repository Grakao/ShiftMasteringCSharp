﻿using Fiap.Web.AspNet4.Models;

namespace Fiap.Web.AspNet4.Repository.Interface
{
	public interface IFornecedorRepository
	{
		public List<FornecedorModel> FindAll();

		public FornecedorModel FindById(int id);

		public void Insert(FornecedorModel fornecedorModel);

		public void Update(FornecedorModel fornecedorModel);

		public void Delete(FornecedorModel fornecedorModel);

		public void Delete(int id);
	}
}
