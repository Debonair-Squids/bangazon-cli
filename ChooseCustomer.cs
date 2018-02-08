using System;
using System.Collections.Generic;

namespace BangazonCLI
{
    public class ChooseCustomer
    {
         public static void ChooseCustomerList()
        {
            //Customer List dictionary
            var customerListing = GetCustomerList();
            int counter = 1;
            // Dictionary<int, Customer> customerList = new Dictionary<int, Customer>();
            
            //Loop that displays the entire list
            foreach(Customer c in customerListing)
            {
                customerList.Add(counter, c);
                // Console.WriteLine($"{counter}. {c.firstName} {c.lastName}");
                counter++;

            }
            
            //Customer pressed choice
            int enteredChoice = 0; 
 
            //Printing the list
            while (!int.TryParse(Console.ReadLine(), out enteredChoice))
            {
                //Initial choice line
                 Console.WriteLine("Please enter a listed number.");
            }
            //Looping over the list when number picked
            foreach(KeyValuePair<int, Customer> kvp in customerList)
            {
                if(enteredChoice == kvp.Key)
                {
                    //Valid choice picked from dictionary
                    Console.Clear();
                    Console.WriteLine($"You selected {kvp.Value.firstName} {kvp.Value.lastName} as the current customer");
                    CustomerManager.currentCustomer = kvp.Value;
                    Console.WriteLine("Press any key.");
                    Console.ReadKey();
                }
                //If invalid number - printed
                else if (enteredChoice > customerList.Count){
                    Console.Clear();
                    Console.WriteLine("Invalid.");
                    Console.ReadLine();
                    ChooseCustomer.ChooseCustomerMenu(cm, db);

                    return;
                }
            }

        }
    }
}