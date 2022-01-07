using dockerMvc.Data;

namespace dockerMvc.Models
{
    public class ProdutoRepository : IRepository
    {
        private readonly ContextApp _context;

        public ProdutoRepository(ContextApp context)
        {
            _context = context;
        }
        public IEnumerable<Produto> Produtos => _context.Produtos;
    }
}