using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebComprasIdentity.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome do Produto")]
        public string NomeProduto { get; set; }

        [Required]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
    }
}
