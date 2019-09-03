using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace BreakfastClub
{
    public class Order
    {
        List<Menu> menus = Menu.MenuItems();
        List<MenuItem> cart = new List<MenuItem>();

        public Order()
        {
        }
        public void PrintMenu()
        {
            int i = 0;

            foreach (var n in menus)
            {
                i++;
                Console.WriteLine(i + ". " + "{0,1} {1,20} {2,15}", n.Name, n.Category, n.Price);
            }
            Console.WriteLine(menus.Count + 1 + ". End Order and Procede to payment");
        }
        public List<MenuItem> AddMenuItem(int input, int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                cart.Add(new MenuItem { OrderName = menus[input].Name, OrderPrice = menus[input].Price });
            }
            return cart;
        }
        public void PrintCart()
        {
            double total = cart.Sum(cart => cart.OrderPrice);

            Console.WriteLine("\n Cart Total: " + total.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine("________________________________");
            int i = 0;
            foreach (var item in cart)
            {
                i++;
                Console.WriteLine(i + "." + item.OrderName + "\t" + item.OrderPrice);
            }
        }
        public double GetTotal()
        {

            double Total = cart.Sum(cart => cart.OrderPrice);

            return Total;

        }


    }

}

