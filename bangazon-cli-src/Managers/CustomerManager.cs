using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace bangazon_cli
{
    public class CustomerManager
    {
        private DatabaseInitializer _db;
        private List<Customer> _customerTable = new List<Customer>();

        // // constructor that connects to THE DB
        // public CustomerManager(DatabaseInitializer db)
        // {
        //     _db = db;
        // }
        // lets make a new customer
        public void AddCustomer(Customer newCustomer)
        {
            _customerTable.Add(newCustomer);
            
        }

        // GET that customer list
        public List<Customer> GetAllCustomers ()
        {
            return _customerTable;
        }

        // GET one customer THIS IS THE ACTIVE CUSTOMER SELECTION
        public Customer GetSingleCustomer(int Id)
        {
            return _customerTable.Where(c => c.CustomerId == Id).Single();
        }
    }
}