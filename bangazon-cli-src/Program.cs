using System;

namespace bangazon_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seed the database if none exists
            var db = new DatabaseInitializer();
            db.VerifyDataExists();

            // Present the main menu
            Console.WriteLine ("*************************************************");
            Console.WriteLine ("Welcome to Bangazon! Command Line Ordering System");
            Console.WriteLine ("*************************************************");
            Console.WriteLine ("1. Create a customer account");
			Console.Write ("> ");

			// Read in the user's choice
			int choice;
			Int32.TryParse (Console.ReadLine(), out choice);

            // If option 1 was chosen, create a new customer account
            if (choice == 1)
            {
                Console.WriteLine ("Enter customer first name");
                Console.Write ("> ");
                string FirstName = Console.ReadLine();
                Console.WriteLine ("Enter customer last name");
                Console.Write ("> ");
                string LastName = Console.ReadLine();
                Console.WriteLine ("Enter customer street address");
                Console.Write ("> ");
                string StreetAddress = Console.ReadLine();
                Console.WriteLine ("Enter customer city");
                Console.Write ("> ");
                string City = Console.ReadLine();
                Console.WriteLine ("Enter customer state");
                Console.Write ("> ");
                string State = Console.ReadLine();
                Console.WriteLine ("Enter customer zip code");
                Console.Write ("> ");
                string Zip = Console.ReadLine();
                Console.WriteLine ("Enter customer phone number");
                Console.Write ("> ");
                string Phone = Console.ReadLine();
                CustomerManager manager = new CustomerManager();
            }
        }
    }
}