using System;

namespace bangazon_cli
{
    public class Required
    {
       // accepts an response, and a UserInput to determine if a user response is an empty string.
        public static string notAOne(string response, string UserInput){
            string input = response;
            if (input.Length == 0){
                do {
                    Console.WriteLine($"{UserInput}.");
                    Console.Write ("> ");
                    input = Console.ReadLine();
                } while (input.Length == 0);
            }
            return input;
        }
    }
}