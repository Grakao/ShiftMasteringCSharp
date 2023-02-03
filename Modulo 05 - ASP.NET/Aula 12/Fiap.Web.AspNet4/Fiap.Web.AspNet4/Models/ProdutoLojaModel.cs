using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.AspNet4.Models
{
	[Table("ProdutoLoja")]
	public class ProdutoLojaModel
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ProdutoLojaId { get; set; }

		public int LojaId { get; set; } // FK da loja

		[ForeignKey("LojaId")]
		public LojaModel Loja { get; set; } // Navigation Property - Loja

		public int ProdutoId { get; set; } // FK do produto

		[ForeignKey("ProdutoId")]
		public ProdutoModel Produto { get; set; } // Navigation Property - Produto
	}
}
