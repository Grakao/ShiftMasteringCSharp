using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Fiap.Web.AspNet4.ViewModel
{
	public class ClientePesquisaViewModel
	{
		[Display(Name="Nome do Cliente")]
		public string ClienteNome { get; set; }

		[Display(Name = "E-mail do Cliente")]
		public string ClienteEmail { get; set; }

		public int RepresentanteId { get; set; }

		public SelectList Representantes { get; set; }

		public IList<ClienteViewModel> Clientes { get; set; }
	}
}
