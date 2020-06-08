using Estoque.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Estoque.Repositories
{
    public interface IEstoqueRepository
    {
        // Tipo genérico onde o que eu passar será passado pela entidade.
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();
        bool Exist(int? id);

        Task<IEnumerable<Fornecedor>> ListarFornecedores();
        Task<Fornecedor> SelecionarFornecedor(int? id);
        Task<IEnumerable<Produto>> ListarProdutos();
        Task<Produto> SelecionarProdutos(int? id);
    }
}
