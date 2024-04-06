using Microsoft.EntityFrameworkCore;

namespace DesafioScSaude.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Usuario> usuarios { get; set; }    
    }
}
