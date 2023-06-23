
using Sober.Application.Contracts.Repositories;
using Sober.Application.Contracts.Repositories.Query.Base;
using Sober.Infrastructure.Config;
using Sober.Infrastructure.Persistence;
using Sober.Infrastructure.Repository;
using Sober.Infrastructure.Repository.Command.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Sober.Infrastructure.Repository.Query.Base;
using Sober.Application.Contracts.Repositories.Command.Base;

namespace Sober.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<SoberSettings>(configuration);
            var serviceProvider = services.BuildServiceProvider();
            var opt = serviceProvider.GetRequiredService<IOptions<SoberSettings>>().Value;

            // For SQLServer Connection
            services.AddDbContext<SoberDbContext>(options =>
            {
                options.UseSqlServer(
                    opt.ConnectionStrings.SoberDbConnection,
                    sqlServerOptionsAction: sqlOptions =>
                    {
                    });
            });

            services.AddScoped(typeof(IQueryRepository<>), typeof(QueryRepository<>));
            services.AddScoped(typeof(ICommandRepository<>), typeof(CommandRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<Func<SoberDbContext>>((provider) => provider.GetService<SoberDbContext>);
            services.AddScoped<DbFactory>();


            services.AddRepositories();

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
              //services.
              //  .AddScoped<IGatewayConfigurationQueryRepository, GatewayConfigurationQueryRepository>();


            return services;
        }
    }
}
