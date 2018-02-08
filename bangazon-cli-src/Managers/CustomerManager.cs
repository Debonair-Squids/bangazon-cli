using System.Collections.Generic;
using System.Linq;

namespace bangazon_cli
{
    public class CustomerManager
    {
        private List<Customer> _customerTable = new List<Customer>();

        private Customer ActiveCustomer;


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
            ActiveCustomer = _customerTable.Where(c => c.CustomerId == Id).Single();
            return ActiveCustomer;
        
        }
    }
}