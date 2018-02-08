using System;

namespace bangazon_cli
{
    public class AddCustomerMenu
    {

         public static void Show()
        {
            Console.Clear();
            Console.WriteLine ("Enter Customer First Name");
            Console.Write ("> ");
            string FirstName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine ("Enter Customer Last Name");
            Console.Write ("> ");
            string LastName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine ("Enter Customer Street Address");
            Console.Write ("> ");
            string StreetAddress = Console.ReadLine();

            Console.Clear();
            Console.WriteLine ("Enter Customer City");
            Console.Write ("> ");
            string City = Console.ReadLine();

            Console.Clear();
            Console.WriteLine ("Enter Customer State");
            Console.Write ("> ");
            string State = Console.ReadLine();

            Console.Clear();
            Console.WriteLine ("Enter Customer Zip Code (5 digit)");
            Console.Write ("> ");
            string Zip = Console.ReadLine();

            Console.Clear();
            Console.WriteLine ("Enter Customer Phone Number (10 digit)");
            Console.Write ("> ");
            string Phone = Console.ReadLine();

            Customer newCustomer = new Customer()
            {
                FirstName = FirstName,
                LastName = LastName,
                StreetAddress = StreetAddress,
                City = City,
                State = State,
                Zip = Zip,
                Phone = Phone
            };
            
            CustomerManager cm = new CustomerManager();
            cm.AddCustomer(newCustomer);

            Console.Clear();
            Console.WriteLine($"You have created a customer! {newCustomer.FirstName} {newCustomer.LastName} is now in the Bangazon System");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

    }
}