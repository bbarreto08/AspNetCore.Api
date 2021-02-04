using BasicCrud.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCrud.Api.Extensions
{
    public static class BasicCrudApiDbContextExtencion
    {
        public static void DefineDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BasicCrudApiDbContext>(
                options =>
                 options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
             ); ;
        }
    }
}
