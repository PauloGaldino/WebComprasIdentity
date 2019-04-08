using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Produto : Base
    {
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
    }
}
