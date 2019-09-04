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
            double SubTotal = cart.Sum(x => x.OrderPrice);
            double SalesTax = SubTotal * 0.07;

            double grandTotal = SubTotal + SalesTax;

       
            int i = 0;
            foreach (var item in cart)
            {
                i++;
                Console.WriteLine(i + "." + item.OrderName + "\t" + item.OrderPrice);
            }
            Console.WriteLine("________________________________");
            Console.WriteLine("\n Sub Total: " + SubTotal.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine("\n Tax: " + SalesTax.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine("\n Grand Total: " + grandTotal.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine("________________________________");
        }
        public double GetTotal()
        {

             double SubTotal = cart.Sum(x => x.OrderPrice);
            double SalesTax = SubTotal * 0.07;

            double grandTotal = SubTotal + SalesTax;


            return grandTotal;

        }


    }

}

