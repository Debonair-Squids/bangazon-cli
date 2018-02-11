
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace bangazon_cli
{
    public class CustomerManager
    {
        private List<Customer> _customerTable = new List<Customer>();

        public void AddCustomer(Customer steve)
        {
            _customerTable.Add(steve);
        }

        public List<Customer> GetAllCustomers ()
        {
            return _customerTable;
        }

        public Customer GetSingleCustomer(int Id)
        {
            return _customerTable.Where(c => c.CustomerId == Id).Single();
        }
    }
}