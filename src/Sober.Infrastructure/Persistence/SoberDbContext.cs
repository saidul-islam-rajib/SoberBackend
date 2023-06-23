using System.Reflection;
using Sober.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Sober.Infrastructure.Persistence
{
    public class SoberDbContext : DbContext
    {
        public SoberDbContext(DbContextOptions<SoberDbContext> options) : base(options)
        {

        }
        #region Tables

        //public DbSet<GatewayConfiguration> GatewayConfigurations { get; set; }


        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
