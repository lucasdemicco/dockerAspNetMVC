using dockerMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace dockerMvc.Data
{
    public class ContextApp : DbContext
    {
        public ContextApp(DbContextOptions<ContextApp> options) : base(options){}

        public DbSet<Produto> Produtos {get; set;}
    }
}