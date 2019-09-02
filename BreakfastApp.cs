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
                    Console.WriteLine( "Total: " + order.total());
                    break;
                }
            }

         
            Console.WriteLine("How would you like to pay? Cash, Card, or Check: ");

            string choice = Console.ReadLine();
            try
            {
                if (choice == "Cash")
                {
                    Console.WriteLine("How much cash would you like to tender?");
                    string amount = Console.ReadLine();
                    double cash = double.Parse(amount);
                    Payment.CashPayment(cash);
                }else if (choice == "Card")
                {
                    Payment.CreditCardPaymentNumber();

                }else if (choice == "Check")
                {
                    Payment.CheckPayment();
                }
                    }
            catch (ArgumentException)
            {
                throw new Exception("Error. Please provide proper response.");
            }



        }
    }
}
