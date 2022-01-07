using dockerMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace dockerMvc.Data
{
    public static class PopulaDb
    {
        public static void IncluiDadosDb(IApplicationBuilder app)
        {
            IncluiDadosDb(
                app.ApplicationServices.GetRequiredService<ContextApp>());
        }

        public static void IncluiDadosDb(ContextApp context)
        {
            context.Database.Migrate();
            if(!context.Produtos.Any())
            {
                context.Produtos.AddRange(
                    new Produto("Luvas de Goleiro", "Futebol", 25m),
                    new Produto("Bola de Basquete", "Basquete", 48.95m),
                    new Produto("Bola de Futebol", "Futebol", 75.50m),
                    new Produto("Meias Grandes", "Calçados", 25m),
                    new Produto("Rede de Vôlei", "Vôlei", 155.50m));
                
                context.SaveChanges();
            }
        }
    }
}