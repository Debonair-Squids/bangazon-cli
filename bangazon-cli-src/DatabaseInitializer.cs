using System;
using Microsoft.Data.Sqlite;

namespace bangazon_cli
{
  public class DatabaseInitializer
  {
    // "bangazon_cli_db"
    //"bangazon_cli_db_test"
    private string _connectionString;
    private SqliteConnection _connection;
    public DatabaseInitializer(string database)
    {
      var env = System.Environment.GetEnvironmentVariable(database);

      _connectionString = $"Data Source={env}";

      _connection = new SqliteConnection(_connectionString);
    }
    public string GetConnectionString()
    {
      return _connectionString;
    }


    // Method to query any table in the database. Takes a string SQL command when called
    public void Query(string command, Action<SqliteDataReader> handler)
    {
      using (_connection)
      {
        // Creates a connection to the database and passes the SQL command in as the CommandText
        _connection.Open();
        SqliteCommand dbcmd = _connection.CreateCommand();
        dbcmd.CommandText = command;

        using (SqliteDataReader dataReader = dbcmd.ExecuteReader())
        {
          handler(dataReader);
        }

        dbcmd.Dispose();
      }
    }

    // Method to update tables in the database
    public string Update(string command)
    {
      using (_connection)
      {
        // Creates a connection to the database and passes the SQL command in as the CommandText
        _connection.Open();
        SqliteCommand dbcmd = _connection.CreateCommand();
        dbcmd.CommandText = command;
        dbcmd.ExecuteNonQuery();
        dbcmd.Dispose();
      }
      return "Updated";
    }

    // Method to insert new rows into the database
    public int Insert(string command)
    {
      // Initializes an ID variable used to hold the returned inserted item ID
      int insertedItemId = 0;

      using (_connection)
      {
        // Creates a connection to the database and passes the SQL command in as the CommandText
        _connection.Open();
        SqliteCommand dbcmd = _connection.CreateCommand();
        dbcmd.CommandText = command;
        dbcmd.ExecuteNonQuery();

        // Accesses the Query method within this class and passes a SQL command
        this.Query("select last_insert_rowid()",
            (SqliteDataReader reader) =>
            {
              while (reader.Read())
              {
                // Loop runs once and assigns the inserted items ID to the initialized insertedItemId variable
                insertedItemId = reader.GetInt32(0);
              }
            }
        );

        dbcmd.Dispose();
      }
      // Returns the inserted item ID
      return insertedItemId;
    }

     public string Delete(string command)
        {
            using(_connection)
            using (SqliteCommand dbcmd = _connection.CreateCommand ())
            {
                _connection.Open();
                dbcmd.CommandText = command;
                dbcmd.ExecuteNonQuery();
                _connection.Close();
            }
            return "Confirm";
        }
  }
}