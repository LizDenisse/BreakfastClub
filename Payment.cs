using System;
using System.Collections.Generic;
using System.Text;

namespace TheBreakfastClub
{
        public class Payment
    {

    
            public static void CreditCardPaymentNumber(/*string crnumber,string date,string cvv*/)
        {
            bool con = true;
            while (con)
            {
                Console.WriteLine("Please enter your 16-digit credit card number: ");
                decimal crnumber = decimal.Parse(Console.ReadLine());
                string crnumberstring = crnumber.ToString();
                if (crnumberstring.Length != 16)
                {
                    Console.WriteLine("You did not enter a valid credit card number.Please try again");
                    con = true;

                }
                else
                {
                    Console.WriteLine("Thank you!");
                    // Console.WriteLine($"{crnumber}");
                    con = false;
                }
            }
        }
        public static void GetCreditCardDate()
        {
            bool con = true;
              while (con)
              {
                Console.WriteLine("Please enter the expiration date (enter two digits for month and four for year): ");
                int date = int.Parse(Console.ReadLine());
                string datestring = date.ToString();
                string substring1 = datestring.Substring(0, 2);
                int datesubstring1 = Int32.Parse(substring1);
                string substring2 = datestring.Substring(2);
                int datesubstring2 = Int32.Parse(substring2);

                if (datestring.Length != 6 || datesubstring1 > 12 || datesubstring2 > 3000 || datesubstring2 < 1900 || datesubstring1 < 0)
                {
                    Console.WriteLine("You did not enter a valid date.Please try again");
                    con = true;
                }
                else
                {
                    Console.WriteLine("Thank you!");
                    con = false;
                }
              }
        }
        public static void Getcreditcardcvv()
        {
            bool con = true;
            while (con)
            {
                Console.WriteLine("Please enter the 3-digit number on the back of your card(cvv): ");
                int cvv = int.Parse(Console.ReadLine());
                string cvvstring = cvv.ToString();
                if (cvvstring.Length != 3)
                {
                    Console.WriteLine("You did not enter a cvv number.Please try again");
                    con = true;
                }
                else
                {
                    Console.WriteLine("Thank you");
                    Console.WriteLine("We have received your payment.Thank you for your business");
                    con = false;
                    break;
                }
            }
        }
         public static void CheckPayment()
            {
               
                    Console.WriteLine("Please enter your check card number: ");
                    decimal cknumber = decimal.Parse(Console.ReadLine());
                     Console.WriteLine("Thank you");
                 
         }
             public static void CashPayment()
             {
                 Console.WriteLine("How much cash do you want to insert: ");
                double amount = double.Parse(Console.ReadLine());
                 Order totalprice = new Order();
                 double checktotal = totalprice.Total;
                 if (checktotal < amount)
                 {
                     double a = amount - checktotal;
                     Console.WriteLine(Math.Round(a, 2));
                 }
                 else
                 {
                     Console.WriteLine("You don`t have enough money");

                 }
             }
            


  
        }
    
}

