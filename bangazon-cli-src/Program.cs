using System;

namespace bangazon_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                choice = MainMenu.Show();

                switch (choice)
                {
                    case 1:
                        // //add cohort
                        // Console.WriteLine("Enter the Name of the Cohort (example: Day 22 or Evening 3)");
                        // Console.Write(">");
                        // string CohortName = Console.ReadLine();

                        // Console.WriteLine("Enter the id of the technology used in this Cohort.");
                        // //run code to display all tech in table with id number and tech name
                        // Dictionary<int, string> techList = tech.GetTech();
                        // foreach(KeyValuePair<int, string> t in techList){
                        //     Console.WriteLine(t.Value + " = " + t.Key);
                        // }

                        // Console.Write(">");
                        // int CohortTech = int.Parse(Console.ReadLine());

                        // // Insert Cohort into database
                        // db.Insert($@"
                        //     INSERT INTO Cohort
                        //     (CohortId, Name, TechId)
                        //     VALUES
                        //     (null, '{CohortName}', {CohortTech})
                        // ");
                        break;
                }
            }
        }
    }
}
