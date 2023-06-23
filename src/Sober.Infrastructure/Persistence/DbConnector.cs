using System.Data;
using System.Data.SqlClient;
using Sober.Infrastructure.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Sober.Infrastructure.Persistence
{
    public class DbConnector
    {
        private readonly IConfiguration _configuration;
        private readonly SoberSettings _settings;
        public DbConnector(IConfiguration configuration, IOptions<SoberSettings> settings)
        {
            _configuration = configuration;
            _settings = settings.Value;
        }

        public IDbConnection CreateConnection()
        {
            var connectionString = _settings.ConnectionStrings.SoberDbConnection;
            return new SqlConnection(connectionString);
        }
    }
}
