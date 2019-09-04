
using System;
using System.Collections.Generic;
​
namespace BreakfastClub
{
  public BreakfastClubApp()
        {
            Console.WriteLine("Welcome to the Breakfast Club.");


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


                Console.WriteLine("Ok, How would you like to pay?");
                Console.WriteLine("1: Credit/Debit Card");
                Console.WriteLine("2: Check");
                Console.WriteLine("3: Cash");
                string pay = Console.ReadLine().Trim().ToLower();

                if (pay == "Credit/Debit" || pay == "1")
                {
                    Payment.Creditcardnumber();
                    Payment.Creditcarddate();
                    Payment.Creditcardcvv();
                }

                else if (pay == "Check" || pay == "2")
                {
                    Payment.CheckPayment();


                }
                else if (pay == "Cash" || pay == "3")
                {
                    Payment.CashPayment();


                }
                else
                {
                    Console.WriteLine("Please leave your information and fill-up pay later form!");
                }

            }


        }

        //public void NewOrder()
        //{
        //    bool run = true;
        //    do
        //    {
        //        Console.WriteLine();
        //        GetOrder();
        //        Console.WriteLine("Take New order? Y/N");
        //        string neworder = Console.ReadLine().ToLower().Trim();
        //        Console.Clear();

        //        if (neworder == "n" || neworder == "No")
        //        {
        //            run = false;
        //        }
        //    }
        //    while (run);


        //}
    }

    //public void PrintMenu()
    //{
    //    Console.WriteLine("Your orders are:");
    //    for (int i = 0; i < BreakfastMenu.Count; i++)
    //    {
    //        Console.WriteLine($"{i++}) {BreakfastMenu[i].Name} + {BreakfastMenu[i].price}");
    //    }
    //    Console.WriteLine("Your total is:");

    //    Console.WriteLine("Your total with 6% tax is:");
    //}

    //public void Checkout()
    //{

    //    PrintMenu();

}

© 2019 GitHub, Inc.
