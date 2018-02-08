using System;
using Microsoft.Data.Sqlite;

namespace bangazon_cli
{
    public class DatabaseInitializer
    {
        private string _connectionString;
        private SqliteConnection _connection;
        public DatabaseInitializer()
        {
            var env = System.Environment.GetEnvironmentVariable("bangazon_cli_db");

            _connectionString = $"Data Source={env}";

            _connection = new SqliteConnection(_connectionString);
        }
    }
}