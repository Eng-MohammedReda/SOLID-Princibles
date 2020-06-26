using System;
using System.Collections.Generic;
using System.Linq;
using solidConsoleDemo;

public class SalesInvoice{
    public static  void CreateInvoice(ShopingCart cart, int custId)                                                                        // -2
        {
            // calc total price 
            //var total = cart..Sum(x => x.price);
            // get customer data
            // save to database 

            PrintingManager.Print("");
            EmailService.send(new object ());
        }
}