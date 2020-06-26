using System;
using System.Collections.Generic;
using System.Linq;
using solidConsoleDemo.ISP;
using solidConsoleDemo.LSP;
using solidConsoleDemo.OCP;

namespace solidConsoleDemo
{
    public class Item { 
        public string code;
        public double price;
        public double quantity; 
    }
    public class Stock
    {
        public static List<Item> items = new List<Item> {
                                 new Item{code="123", price=10, quantity=10},
                                 new Item{code="456", price=12, quantity=2},
                                 new Item{code="789", price=14, quantity=1}
        };

        public static bool IsAvailableQuantity(Item item){
            if(item.quantity <items.Where(x => x.code == item.code).FirstOrDefault().quantity ){
                return true;
            }else {return false;}
        }
    }

    public class ShopingCart
    {
        List<Item> cartItems = new List<Item>();

        public void RemoveFromCart(Item item)
        {
            if (cartItems.Contains(item)) cartItems.Remove(item);
        }
        public bool Add(Item item)
        {
            // check available quantity
           
            if (Stock.IsAvailableQuantity(item))
            {
                cartItems.Add(item); return true;
            }
            else { return false; }
        }
        
        public int GetItemsCount(){return cartItems.Count;}
         
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            
           DIP.Notification notification =
            new  DIP.Notification(new DIP.WebMail());
          
           notification.mailType = new DIP.Gmail();
           notification.SendMail();
           
           Console.ReadKey();
        }
    }
}
