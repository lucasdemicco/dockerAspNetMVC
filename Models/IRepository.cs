namespace dockerMvc.Models
{
    public interface IRepository
    {
         IEnumerable<Produto> Produtos {get;}
    }
}