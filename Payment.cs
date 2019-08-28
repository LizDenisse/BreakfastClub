using System;
using System.Collections.Generic;
using System.Text;

namespace TheBreakfastClub
{
   public class Payment
    {
        private static double price;
        public static void CreditCardPayment(/*string crnumber,string date,string cvv*/)
        {
            bool con = true;
            
            while (true)
            {
                
                Console.WriteLine("Please enter your credit card number: ");
                string crnumber = Console.ReadLine();
                char[] credit = crnumber.ToCharArray();
                foreach (char c in credit)
                {
                    if (!char.IsDigit(c)) { 
                        Console.WriteLine("You did not enter a number.Please try again");
                    con = false; }
                    else
                    {
                        break;
                    }
                }
                if (crnumber.Length == 16)
                {
                    Console.WriteLine($"{ credit}");
                    Console.WriteLine();
                }
                break;
                
            }
            while (true)
            {

                Console.WriteLine("Please enter the expiration date (enter two digits for month and four for year): ");
                string date = Console.ReadLine();
                char[] data = date.ToCharArray();
                foreach (char c in data)
                {
                    if (!char.IsDigit(c))
                    {
                        Console.WriteLine("You did not enter a number.Please try again");
                        con = false;
                    }

                    else
                    {
                        break;
                    }
                }

                if (date.Length == 6)
                {
                    Console.WriteLine($"{data}");
                    Console.WriteLine();
                }
                Console.WriteLine($"{ data}");
                break;
            }
            while (true)
            {
                Console.WriteLine("Please enter the number on the back of your card(cvv): ");
                string cvv = Console.ReadLine();
                char[] backofcard = cvv.ToCharArray();
                foreach (char c in backofcard)
                {
                    if (!char.IsDigit(c))
                        Console.WriteLine("You did not enter a number.Please try again");
                    con = false;
                }
                if (cvv.Length == 3)
                {
                    Console.WriteLine($"{backofcard}");
                    Console.WriteLine();
                }
                // Console.WriteLine($"{backofcard}");
                break;
            }
            

        }
       public static void CheckPayment()
        {
            bool con = true;
            while (true)
            {
                Console.WriteLine("Please enter your check card number: ");
                string cknumber = Console.ReadLine();
                char[] checkno = cknumber.ToCharArray();
                foreach (char c in checkno)
                {
                 if (!char.IsDigit(c))
                 Console.WriteLine("You did not enter a number.Please try again");
                 con = false;
                }
            }
           // Console.WriteLine("Thank you");
           
        }
        public static void CashPayment(double amount)
        {
            Console.WriteLine("How much cash do you want to insert: ");
            amount = double.Parse(Console.ReadLine());
            if (price < amount)
            {
                double a = amount - price;

                Console.WriteLine(Math.Round(a, 2));
            }
            else 
            {
                Console.WriteLine("You don`t have enough money");
                
            }
        }
        public static void Taxes(double amount)
        {
            double tax = amount * (6 / 100);
            Console.WriteLine(tax);
            
        }

    }
}
