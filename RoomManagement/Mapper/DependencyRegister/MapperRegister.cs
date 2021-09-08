using Mapper.Implementations;
using Mapper.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper.DependencyRegister
{
    public static class MappperRegister
    {
        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            services.AddScoped<IUserMapper, UserMapper>();

            return services;

        }
    }
}
