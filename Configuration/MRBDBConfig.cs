using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MRBHub.Web.ORM;

namespace TehranEnergyApiClient.Web.Configuration
{
    public static class MRBDBConfig
    {
        public static void AddInternalDBConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<MRBDbContext>(options =>
              options.UseSqlServer(configuration.GetConnectionString("mrbinternal")));
        }
    }
}
