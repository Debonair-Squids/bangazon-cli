using System.Collections.Generic;
using System.Linq;

namespace bangazon_cli
{
    public class CustomerPaymentManager
    {
        private List<CustomerPayment> _paymentTable = new List<CustomerPayment>();

        public void AddPayment(CustomerPayment currentPayment)
        {
            int currentPaymentId = 0;
            _paymentTable.Add(currentPayment);
            // The PayType will be passed in to the insert method. The insert method will return the PayTypeId.
            // If the PaymentTypeId is still zero, it didn't work
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