using Estoque.Data;
using Estoque.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estoque.Repositories
{
    public class EstoqueRepository : IEstoqueRepository
    {
        private readonly ApplicationDbContext _context;
        public EstoqueRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<IEnumerable<Fornecedor>> ListarFornecedores()
        {
            return await _context.Fornecedores.ToListAsync();
        }

        public async Task<Fornecedor> SelecionarFornecedor(int? id)
        {
            return await _context.Fornecedores.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<IEnumerable<Produto>> ListarProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> SelecionarProdutos(int? id)
        {
            return await _context.Produtos.FirstOrDefaultAsync(p => p.Id == id);
        }

        public bool Exist(int? id)
        {
            return _context.Fornecedores.Any(e => e.Id == id);
        }
    }
}
