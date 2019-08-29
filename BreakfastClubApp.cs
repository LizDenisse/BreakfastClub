
using System;
using System.Collections.Generic;

namespace BreakfastClub
{
    class BreakfastClubApp
    {
        List<Menu> BreakfastMenu { get; set; }
        //public Menu menu;
        //public Order takeorder;
        //public Payment {get; set}

        public BreakfastClubApp()
        {
            Console.WriteLine("Welcome to the Breakfast Club.");


        }

        public void GetOrder()
        {
            Console.WriteLine("What do you like to have for your breakfast today?");

        }

        public void PrintMenu()
        {
            Console.WriteLine("Your orders are:");
            for (int i = 0; i < BreakfastMenu.Count; i++)
            {
                Console.WriteLine($"{i++}) {BreakfastMenu[i].Name} + {BreakfastMenu[i].price}");
            }
            Console.WriteLine("Your total is:");

            Console.WriteLine("Your total with 6% tax is:");
        }

        public void Checkout()
        {

            PrintMenu();
            Console.WriteLine("How would you like to pay?");
            Console.WriteLine("1: Credit/Debit Card");
            Console.WriteLine("2: Check");
            Console.WriteLine("3: Cash");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "Credit/Debit" || input == "1")
            {
                Console.WriteLine();
                Payment a = new Payment();
            }

            else if (input == "Check" || input == "2")
            {
                Console.WriteLine();
                Console.Write("Please enter your check number");
                payment = new Payment();
                payment.CheckPayment();

            }
            else if (input == "Cash" || input == "3")
            {
                Console.WriteLine();
                Console.WriteLine("Please input the amount of cash change");
                payment = new Payment();
                payment.CashPayment();

            }
            else
            {
                Console.WriteLine("Please leave your information and fill-up pay later form!");
            }
        }
    }
}