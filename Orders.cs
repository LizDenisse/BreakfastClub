using System;
using System.Collections.Generic;
using System.Text;

namespace BreakfastClub

{
    public class Order
    {
        List<Menu> menus = Menu.MenuItems();
        List<MenuItem> cart = new List<MenuItem>();


        public Order()
        {
        }

        public List<MenuItem> AddMenuItem(int input)
        {
            List<MenuItem> cart = new List<MenuItem>();

            cart.Add(new MenuItem { OrderName = menus[input].Name, OrderPrice = menus[input].Price });

            return cart;
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
    }

    internal class Payment
    {
        private Menu menu;

    }

    public class MenuItem
    {
        internal object OrderName;
        internal object OrderPrice;
    }



}

