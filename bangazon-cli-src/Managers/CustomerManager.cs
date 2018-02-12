using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace bangazon_cli
{
    public class CustomerManager
    {
        private List<Customer> _customerTable = new List<Customer>();
        private DatabaseInitializer _db;

        public CustomerManager(DatabaseInitializer db)
        {
            _db = db;
        }

        public int AddCustomer(Customer newCustomer)
        {
            _customerTable.Add(newCustomer);
            int id = _db.Insert($"insert into Customer values (null, '{newCustomer.FirstName}','{newCustomer.LastName}','{newCustomer.StreetAddress}','{newCustomer.City}','{newCustomer.State}','{newCustomer.Zip}','{newCustomer.Phone}') ");
            return id;
        }

        public List<Customer> GetAllCustomers()
        {
            _customerTable.Clear();

            _db.Query($"SELECT CustomerId, FirstName, LastName FROM Customer;",
            (SqliteDataReader reader) =>
            {
                while (reader.Read())
                {
                    {
                        Customer customer = new Customer()
                        {
                            CustomerId = reader.GetInt32(0),
                            FirstName = reader[1].ToString(),
                            LastName = reader[2].ToString()
                        };
                        _customerTable.Add(customer);
                    };
                }
            });
            return _customerTable;
        }

        public Customer GetSingleCustomer(int Id)
        {
            _customerTable.Clear();

            _db.Query($"SELECT CustomerId, FirstName, LastName, StreetAddress, City, State, Zip, Phone FROM Customer;",
            (SqliteDataReader reader) =>
            {
                while (reader.Read())
                {
                    {
                        Customer customer = new Customer()
                        {
                            CustomerId = reader.GetInt32(0),
                            FirstName = reader[1].ToString(),
                            LastName = reader[2].ToString(),
                            StreetAddress = reader[3].ToString(),
                            City = reader[4].ToString(),
                            State = reader[5].ToString(),
                            Zip = reader[6].ToString(),
                            Phone = reader[7].ToString()
                        };
                        _customerTable.Add(customer);
                    };
                }
            });
            return _customerTable.Where(c => c.CustomerId == Id).Single();
        }
    }
}