using System;

namespace bangazon_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu.Show();
            DatabaseInitializer db = new DatabaseInitializer("bangazon_cli_db");
        }
    }
}