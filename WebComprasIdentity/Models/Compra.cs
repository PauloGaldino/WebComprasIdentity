using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebComprasIdentity.Models
{
    [Table("Compra")]
    public class Compra
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Código do Produto")]
        public int ProdutoId { get; set; }

        [Required]
        [Display(Name = "Nome do Produto")]
        public string NomeProduto { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
    }
}
