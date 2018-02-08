// using System;

// namespace bangazon_cli
// {
//     public class AddCustomer
//     {
//          public static void AddCustomerMenu(CustomerManager cm)
//         {
//             Console.Clear();
//             Console.WriteLine ("Enter Customer First Name");
//             Console.Write ("> ");
//             string FirstName = Console.ReadLine();
//             FirstName = Required.notAOne(FirstName, "Customer First Name Required");

//             Console.Clear();
//             Console.WriteLine ("Enter Customer Last Name");
//             Console.Write ("> ");
//             string LastName = Console.ReadLine();
//             LastName = Required.notAOne(LastName, "Customer Last Name Required");

//             Console.Clear();
//             Console.WriteLine ("Enter Customer Street Address");
//             Console.Write ("> ");
//             string StreetAddress = Console.ReadLine();
//             StreetAddress = Required.notAOne(StreetAddress, "Customer Street Address Required");

//             Console.Clear();
//             Console.WriteLine ("Enter Customer City");
//             Console.Write ("> ");
//             string City = Console.ReadLine();
//             City = Required.notAOne(City, "Customer City Required");

//             Console.Clear();
//             Console.WriteLine ("Enter Customer State");
//             Console.Write ("> ");
//             string State = Console.ReadLine();
//             State = Required.notAOne(State, "Customer State Required");

//             Console.Clear();
//             int Zip = 0;
//             do {
//                 Console.WriteLine ("Enter Customer Zip Code");
//                 Console.Write ("> ");
//                 string stringZip = Console.ReadLine();
//                 stringZip = Required.notAOne(stringZip, "Customer Zip Code Required");
//                 try{

//                     Zip = Convert.ToInt32(stringZip);

//                 } catch {
//                     Console.WriteLine("Please enter a five digit Zip Code.");
//                     stringZip = Console.ReadLine();
//                     Int32.TryParse(stringZip, out Zip);
//                 }

//             } while (Zip == 0);

//             Console.Clear();
//             int Phone = 0;
//             do {
//                 Console.WriteLine ("Enter Customer Phone Number");
//                 Console.Write ("> ");
//                 string stringPhone = Console.ReadLine();
//                 stringPhone = Required.notAOne(stringPhone, "Customer Phone Number Required");
//                 try{

//                     Phone = Convert.ToInt32(stringPhone);

//                 } catch {
//                     Console.WriteLine("Please enter a ten digit Phone Number.");
//                     stringPhone = Console.ReadLine();
//                     Int32.TryParse(stringPhone, out Phone);
//                 }

//             } while (Phone == 0);
//             Customer newCustomer = new Customer()
//             {
//                 FirstName = FirstName,
//                 LastName = LastName,
//                 StreetAddress = StreetAddress,
//                 City = City,
//                 State = State,
//                 Zip = Zip,
//                 Phone = Phone
//             };
//             cm.AddCustomer(newCustomer);

//             Console.Clear();
//             Console.WriteLine($"You have created a customer! {newCustomer.FirstName} {newCustomer.LastName} is now in the Bangazon System");
//             Console.WriteLine("Press any key to continue");
//             Console.ReadKey();
//         }

//     }
// }