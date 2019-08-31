using System;
using System.Collections;
using System.Collections.Generic;
namespace TheBreakfastClub
{
    public class BreakfastApp
    {
        public BreakfastApp()
        {
        }
        public void Run()
        {
            bool co = true;
           
            List<Menu> menus = Menu.MenuItems();

            Order order = new Order();

         


            while (co)
            {
                order.PrintMenu();

                Console.WriteLine("Which Item would you like?");

               string input = Console.ReadLine();
                int i = int.Parse(input);
                order.Cart(menus[i]);


                Console.WriteLine("Would you like more?");
                string answer = Console.ReadLine();



                if (answer == "y")
                {
                    Console.Clear();
                    continue;

                }
                else
                {
                    order.PrintCart();
                    Console.WriteLine("This is your cart to go!");
                    Console.WriteLine("How would you like to pay?");
                    Console.WriteLine(order.Total);
                    co = false;
                }

                


            }




        }
    }
}
