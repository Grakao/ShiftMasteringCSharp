﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.AspNet4.Models
{
	[Table("Fornecedor")]
	public class FornecedorModel
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int FornecedorId { get; set; }

		[Required]
		[StringLength(70)]
		public string FornecedorNome { get; set; }

		[Required]
		[StringLength(14)]
		public string Cnpj { get; set; }

		[StringLength(11)]
		public string? Telefone { get; set; }

		[EmailAddress]
		public string? Email { get; set; }
	}
}
