using System;
using Microsoft.Data.Sqlite;

namespace bangazon_cli
{
    public class DatabaseInitializer
    {
        private string _connectionString;
        private SqliteConnection _connection;
        public DatabaseInitializer(string database)
        {
            string env = System.Environment.GetEnvironmentVariable($"{database}");

            _connectionString = $"Data Source={env}";

            _connection = new SqliteConnection(_connectionString);
        }
    }
}