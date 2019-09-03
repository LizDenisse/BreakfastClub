using System;
using System.Collections.Generic;
using System.Linq;


namespace BreakfastClub
{
    public class BreakfastClubApp
    {
        List<Menu> menus = Menu.MenuItems();
        Order order = new Order();
        int input = 0;
        string inp = "";
        double amount = 0;
        public void RunApp()
        {
            Console.WriteLine("Welcome to the Breakfast Club ");
            bool orderMore = true;
            while (orderMore)
            {
                Console.WriteLine("\n Select a Number from the Menu ");
                Console.WriteLine("_______________________________");
                order.PrintMenu();
                inp = Console.ReadLine();
                input = int.Parse(inp);

                if (input > 0 && input < menus.Count)
                {
                    Console.WriteLine(menus[input].Name + "  \n Description " + menus[input].Description);
                    Console.WriteLine("do you want to buy this item? ");
                    string b = Console.ReadLine().ToLower().Trim();

                    if (b == "y")
                    {
                        if (input > 0 && input < menus.Count)
                        {
                            Console.WriteLine("How Many ?");
                            string h = Console.ReadLine();
                            int howMany = int.Parse(h);
                            order.AddMenuItem(input, howMany);
                            order.PrintCart();
                        }
                    }
                }
                else
                {
                    order.PrintCart();
                    Checkout();
                    break;
                }
            }
        }
        public void Checkout()
        {
            Console.WriteLine("Ok, How would you like to pay?");
            Console.WriteLine("1: Credit/Debit Card");
            Console.WriteLine("2: Check");
            Console.WriteLine("3: Cash");
            string pay = Console.ReadLine();

            Payment payment = new Payment();

            if (pay == "Credit/Debit" || pay == "1")
            {
                payment.CreditCardPaymentNumber();
                payment.GetCreditCardDate();
                payment.Getcreditcardcvv();
            }
            else if (pay == "Check" || pay == "2")
            {
                payment.CheckPayment();
            }
            else if (pay == "Cash" || pay == "3")
            {
                payment.CashPayment();
            }
            else
            {
                Console.WriteLine("Please leave your information and fill-up pay later form!");
                Console.WriteLine("Invalid entry please select 1-Card, 2- Check or 3- Cash ");
                pay = Console.ReadLine();
            }

            Console.WriteLine("Good Bye, Come back soon");
        }

    }


}





