using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;

namespace RpgHelper.Infra.Database
{
    public class DatabaseConfiguration
    {
        private readonly IConfiguration _configuration;

        public DatabaseConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void CreateConnection()
        {
            string connection = _configuration.GetConnectionString("DefaultConnection");
            using var conn = new SqliteConnection(connection);

            conn.Open();

            using var command = conn.CreateCommand();
        }
    }
}
