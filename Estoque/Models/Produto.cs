using System.ComponentModel.DataAnnotations;

namespace Estoque.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int FornecedorId { get; set; }
    }
}
