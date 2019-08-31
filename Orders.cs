using System;
using System.Collections.Generic;

namespace BreakfastClub

{
    public class Order
    {
        List<Menu> menus = Menu.MenuItems();
        List<Menu> cart = new List<Menu>();
        public double Total
        {
            get
            {
                return Total;
            }
            set
            {
                foreach (Menu n in cart)
                {
                    Total = +n.Price;
                }
            }
        }




        public Order()
        {

        }

        public void Cart(Menu m)
        {

            Console.WriteLine("Ok! adding that item to the list");

            cart.Add(m);

        }

        public void PrintCart()
        {
            foreach (Menu n in cart)
            {
                Console.WriteLine("Your cart below!");
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
