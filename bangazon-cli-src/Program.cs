using System;

namespace bangazon_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            DatabaseInitializer db = new DatabaseInitializer("bangazon_cli_db");
            CustomerManager cm = new CustomerManager(db);


            int choice;

            do
            {
                // Show the Main Menu
                choice = menu.Show();

                switch (choice)
                {
                    case 1:
                        // Displays the Create Customer Menu
                        AddCustomerMenu.Show(cm);
                        break;
                    // case 2:
                    //     ChooseCustomer.ChooseCustomerMenu(cm, db);
                    //     break;
                    // case 3:
                    //     if (CustomerManager.currentCustomer == null)
                    //     {
                    //         ChooseCustomer.ChooseCustomerMenu(cm, db);
                    //     }
                    //     CreatePayment.CreatePaymentMenu(paytm);
                    //     break;
                    // case 4:
                    //     if (CustomerManager.currentCustomer == null)
                    //     {
                    //         ChooseCustomer.ChooseCustomerMenu(cm, db);
                    //     }
                    //     AddProductToSell.DoAction(pm, ptm);
                    //     break;
                    // case 5:
                    // if (CustomerManager.currentCustomer == null)
                    //     {
                    //         ChooseCustomer.ChooseCustomerMenu(cm, db);
                    //     }
                    //     AddProductOrder.AddProductToOrder(cm, pm, om);
                    //     break;
                    // case 6:
                    //      if (CustomerManager.currentCustomer == null)
                    //         {
                    //             ChooseCustomer.ChooseCustomerMenu(cm, db);
                    //         }
                    //     CompleteOrder.CompleteOrderMenu(om, pm, paytm);
                    //     break;
                    // case 7:
                    //     if (CustomerManager.currentCustomer == null)
                    //     {
                    //         ChooseCustomer.ChooseCustomerMenu(cm, db);
                    //     }
                    //     RemoveProductToSell.RemoveProductToSellMenu(pm);
                    //     break;
                    // case 8:
                    //     if (CustomerManager.currentCustomer == null)
                    //     {
                    //         ChooseCustomer.ChooseCustomerMenu(cm, db);
                    //     }
                    //     UpdateProduct.UpdateProductMenu(pm);
                    //     break;
                    // case 9:
                    //     if (CustomerManager.currentCustomer == null)
                    //     {
                    //         ChooseCustomer.ChooseCustomerMenu(cm, db);
                    //     }
                    //     ShowStale.DoAction(om);
                    //     break;
                    // case 10:
                    //     if (CustomerManager.currentCustomer == null)
                    //     {
                    //         ChooseCustomer.ChooseCustomerMenu(cm, db);
                    //     }
                    //     RevenueReport.ShowRevenueReport(om);
                    //     break;
                    // case 11:
                    //     ProductPopularityReport.ProductPopularityReportMenu(pm);
                    //     break;
                }
            } while(choice != 12);
        }
    }
}