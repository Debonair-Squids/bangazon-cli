//Author: Erin Agobert
using System;
using System.Collections.Generic;
using bangazon_cli;
using Xunit;

public class StaleProducts_Should 
{
    /*Given a user wants to see products that aren't selling
    -When the user selects the option to view stale products
    -Then the user should be presented with a list of all products that meet any of the following criteria
        -Has never been added to an order, and has been in the system for more than 180 days
        -Has been added to an order, but the order hasn't been completed, and the order was created more than 90 days ago
        -Has been added to one, or more orders, and the order were completed, but there is remaining quantity for the product, and the product has been in the system for more than 180 days
        
    -Pro tip: Investigate the SQL Union operation to fulfill these requirements
*/


}