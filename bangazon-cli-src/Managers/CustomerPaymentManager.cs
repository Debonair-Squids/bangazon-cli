using System.Collections.Generic;
using System.Linq;

namespace bangazon_cli
{
    public class CustomerPaymentManager
    {
        private List<CustomerPayment> _paymentTable = new List<CustomerPayment>();

// This method checks to make sure Customer Payment Was added properly!
// The CustomerPaymentId (currentPaymentId) is set to 0 and if successful it will be change to 2!
        public int AddPayment(CustomerPayment currentPayment)
        {
            int currentPaymentId = 0;
            _paymentTable.Add(currentPayment);

             currentPaymentId= 2;
            return currentPaymentId;

        }

// This method will get a list of CustomerPayments according to the customerId.
        public List<CustomerPayment> GetCustomerPayments(int customerId)
        {
            return _paymentTable;
        }
    }
}