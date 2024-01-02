

using Microsoft.EntityFrameworkCore;
using TesteDotNet.Repository.Entities;

namespace TesteDotNet.Repository.Context
{
    public class UsuarioContext : DbContext 
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base (options) 
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
