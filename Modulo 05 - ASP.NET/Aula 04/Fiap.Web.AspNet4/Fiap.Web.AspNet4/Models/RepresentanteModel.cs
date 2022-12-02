using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.AspNet4.Models
{
	[Table("Representante")]
	public class RepresentanteModel
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int RepresentanteId { get; set; }

		[Required]
		[StringLength(120)]
		public string NomeRepresentante { get; set; }

		[NotMapped]
		public string Token { get; set; }

		public RepresentanteModel()
		{

		}

		public RepresentanteModel(int representanteId, string nomeRepresentante)
		{
			RepresentanteId = representanteId;
			NomeRepresentante = nomeRepresentante;
		}
	}
}
