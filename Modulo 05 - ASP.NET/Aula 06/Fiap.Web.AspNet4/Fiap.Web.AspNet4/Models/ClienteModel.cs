using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.AspNet4.Models
{
	[Table("Cliente")]
	public class ClienteModel
	{
		[HiddenInput]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ClienteId { get; set; }

		[Display(Name = "Nome do Cliente")]
		[Required(ErrorMessage = "O nome do cliente é obrigatório!")]
		[MinLength(6, ErrorMessage = "São necessários pelo menos 6 caracteres para o nome do cliente.")]
		[MaxLength(70, ErrorMessage = "Limite máximo de 70 caracteres para o nome do cliente.")]
		public string? Nome { get; set; }

		[Display(Name = "Sobrenome do Cliente")]
		public string? Sobrenome { get; set; }

		[Display(Name = "Endereço de E-mail")]
		[Required(ErrorMessage = "O Email do cliente é obrigatório!")]
		[EmailAddress(ErrorMessage = "Digite um endereço de e-mail válido.")]
		public string? Email { get; set; }

		[Display(Name = "Data de Nascimento")]
		[Required(ErrorMessage = "A data de nascimento é obrigatória!")]
		[DataType(DataType.Date, ErrorMessage = "Data de nascimento incorreta.")]
		public DateTime DataNascimento { get; set; }

		[Display(Name = "Observações")]
		public string? Observacao { get; set; }

		// FK
		public int RepresentanteId { get; set; }
		// Navigation Object
		[ForeignKey("RepresentanteId")]
		public RepresentanteModel Representante { get; set; }
	}
}
