using System.ComponentModel.DataAnnotations;

namespace Estoque.Models
{
    public class Fornecedor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2,ErrorMessage = "O campo nome deve conter pelo menos 2 caracteres.")]
        public string Nome { get; set; }
    }
}
