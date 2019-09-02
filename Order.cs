using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;


namespace TheBreakfastClub
{

    public class Order
    {
        List<Menu> menus = Menu.MenuItems();
        List<Menu> cart = new List<Menu>();
      public double Total { get; set; }
        




        public Order()
        {

        }
        public double total()
        {
          
            foreach(Menu c in cart)
            {
                Total = Total + c.Price;
            }
            return Total;
        }

        public void Cart(Menu m)
        {

            Console.WriteLine("Ok! adding that item to the list");

            cart.Add(m);

        }

        public void PrintCart()
        {
            Console.WriteLine("Your cart below!");
            foreach (Menu n in cart)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                
              
                Console.WriteLine(n.Name + " \t " + n.Price);
            }
           
            
        }


        public void PrintMenu()
        {
            int i = 0;
            foreach (var n in menus)
            {
                i++;
                Console.WriteLine(i + "." + n.Name + " \t " + n.Price);

            }
            
        }






        public class MenuOrder
        {
            public object OrderName { get; set; }
            public object OrderPrice { get; set; }
        }



    }
}

