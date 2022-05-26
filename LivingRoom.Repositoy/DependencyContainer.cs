using LivingRoom.Entities.Interfaces;
using LivingRoom.Repositoy.Models;
using LivingRoom.Repositoy.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingRoom.Repositoy
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<bdtosahdContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("LivingRoom")));

            services.AddScoped<IUsuarioRepository, UserRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
