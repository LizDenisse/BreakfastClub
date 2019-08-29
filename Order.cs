using System;
using System.Collections.Generic;
using System.Collections;

namespace TheBreakfastClub
{
    
    public class Order
    {
        public double total { get; set; }
        List<Menu> order = new List<Menu>();

        public Order()
        {
            Console.WriteLine("Hello User! Welcome to the Breakfast Club!");
            Console.WriteLine("Have a look at our menu!");
        }


        private void PrintMenu(List<Menu> menus)
        {
            int i = 0;
            foreach (Menu n in menus)
            {

                Console.WriteLine(i++ + " " + n.Name);
            }
        }


        private void ItemDescription(List<Menu> item, int index)
        {
            Menu i = item[index];
            Console.WriteLine(i.Description);
        }

        private double Quantity(int index, List<Menu> item, int amount)
        {

            Menu i = item[index];

           total = i.Price * amount;

            return total;
        }


    }
}
