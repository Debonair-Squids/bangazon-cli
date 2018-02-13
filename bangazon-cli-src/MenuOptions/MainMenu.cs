using System;

namespace bangazon_cli
{
    public class MainMenu
    {
        private static CustomerManager cm;

        public int Show()
        {
            Console.Clear();
            Console.WriteLine ("ITS BANGAZON BITCHES");
            Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine ("1. Create a customer account");
            Console.WriteLine ("2. Select Customer");
            Console.WriteLine ("3. Create Payment Option");
            Console.WriteLine ("4. Add Product to Sell");
            Console.WriteLine ("5. Add Product to Shopping Cart");
            Console.WriteLine ("6. Complete Order");
            Console.WriteLine ("7. Remove Customer Product");
            Console.WriteLine ("8. Update Product Information");
            Console.WriteLine ("9. Show Stale Products");
            Console.WriteLine ("10. Show Customer Revenue Report");
            Console.WriteLine ("11. Show Overall Product Popularity");
            Console.WriteLine ("12. GIT OUT");
            Console.Write ("> ");


			int choice;
			Int32.TryParse (Console.ReadLine(), out choice);
            return choice;
        }
    }
}