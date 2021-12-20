using Microsoft.EntityFrameworkCore;

namespace Mochileiro.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Cadastro> cadastros { get; set; }
        public DbSet<Contato> contatos { get; set; }
    
            
    }


}
