
using System;
using System.Collections.Generic;

namespace BreakfastClub
{
    class BreakfastClubApp
    {


        public BreakfastClubApp()
        {
            Console.WriteLine("Welcome to the Breakfast Club.");
            // Run();
            Checkout();
        }


        public void Run()
        {
            bool ordercont = true;
            List<Menu> menus = Menu.MenuItems();

            Console.WriteLine("What do you like to have for your breakfast today?");
            Console.WriteLine();
            Order order = new Order();

            while (ordercont)
            {
                order.PrintMenu();
                Console.WriteLine();
                Console.WriteLine("Which item would you like?");
                string input = Console.ReadLine();
                int i = int.Parse(input);
                order.Cart(menus[i]);
                Console.WriteLine();

                Console.WriteLine("Would you like to have more item? Y/N");
                String answer = Console.ReadLine();

                if (answer == "y" || answer == "yes")
                {
                    Console.Clear();
                    continue;
                }

                else
                {
                    order.PrintCart();
                    Console.WriteLine("You have ordered:");

                    Console.WriteLine(order.Total);
                    ordercont = false;
                }

            }

        }

        public void Checkout()
        {
            Console.WriteLine("Ok, How would you like to pay?");
            Console.WriteLine("Please select a payment method (1-3)");
            Console.WriteLine("1: Credit/Debit Card");
            Console.WriteLine("2: Check");
            Console.WriteLine("3: Cash");
            Console.WriteLine();
            string pay = Console.ReadLine().Trim().ToLower();

            if (pay == "Credit/Debit" || pay == "1")
            {
                Console.WriteLine("Cradit/Debit Card Payment:");
                Payment.CreditCardPaymentNumber();
                Payment.GetCreditCardDate();
                Payment.Getcreditcardcvv();
            }

            else if (pay == "Check" || pay == "2")
            {
                Console.WriteLine("Check Payment:");
                Payment.CheckPayment();
            }
            else if (pay == "Cash" || pay == "3")
            {
                Console.WriteLine("Cash Payment:");
                Payment.CashPayment(12);
            }
            else
            {
                Console.WriteLine("Please leave your information and fill-up pay later form!");
            }
        }


    }



}

