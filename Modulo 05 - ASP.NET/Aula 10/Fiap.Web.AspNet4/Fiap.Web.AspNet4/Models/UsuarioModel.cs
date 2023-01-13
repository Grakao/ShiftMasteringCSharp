using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.AspNet4.Models
{
	public class UsuarioModel
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int UsuarioId { get; set; }

		[Required]
		[StringLength(50)]
		public string? UsuarioNome { get; set; }

		public string? UsuarioEmail { get; set; }

		public string? UsuarioSenha { get; set; }

		public DateTime CreatedAt { get; set; }
	}
}