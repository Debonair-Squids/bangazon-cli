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
            // Replace {you} with the correct value
            _connectionString = $"Data Source=.db";


            _connection = new SqliteConnection(_connectionString);
        }

        internal void VerifyDataExists()
        {
            throw new NotImplementedException();
        }
    }
}