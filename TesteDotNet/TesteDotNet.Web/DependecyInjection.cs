using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using TesteDotNet.Repository.Context;

namespace TesteDotNet.Web
{
    public static class DependecyInjection
    {
        public static WebApplicationBuilder ConfigureDI(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<UsuarioContext>(options =>
             options.UseSqlServer(builder.Configuration.GetConnectionString("UsuariosConnectionString")));

            return builder;
        }
      
    }
}
