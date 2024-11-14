using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Repositories.Interfaces;
using Infrastructure.Entities;
using Infrastructure.Repositories;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddDbContext<ChatDatabase>(opt =>
            {
                opt.UseNpgsql(configuration.GetConnectionString("WebApiDatabase"));
            });
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Message>, GenericRepository<Message>>();
            services.AddScoped<IMessageRespository, MessageRepository>();


            return services;
        }
    }
}
