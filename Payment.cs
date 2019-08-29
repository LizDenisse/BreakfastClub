using System;
namespace TheBreakfastClub
{
    public class Payment
    {

        public Payment(Menu item)
        {
            Console.WriteLine("You owe " + item.Price + " dollars.");
            Console.WriteLine("How would you like to pay?");

            string[] arr = new string[] {"1) Cash",
    "2) Credit",
    "3) Check"};

            string str = string.Join("\n", arr);
            Console.WriteLine(str);


        }





        public void CreditCardPayment(Menu item)
        {
            Console.WriteLine("Please enter Card Number: ");
            string input = Console.ReadLine();
            try
            {
                Convert.ToInt32(input);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("We were unable to proccess those number please try again.");
            }

            try
            {
                Console.WriteLine("Please enter CVV: ");

                string cvv = Console.ReadLine();
                Convert.ToInt32(cvv);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("We were unable to process those numbers, please try again.");
            }

            try
            {
                Console.WriteLine("Please enter the expiration date: ");
                string date = Console.ReadLine();
                Convert.ToInt32(date);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("We were unable to process those numbers please try again.");
            }

        }

        public void Cash(Menu item, int amount)
        {
            Console.WriteLine("You owe " + item.Price);

            Console.WriteLine("Cash Tendered: ");
            amount = Convert.ToInt32(Console.ReadLine());

            int change = (int)(amount - item.Price);
            Console.WriteLine(change);
        }
        public void Check(Menu item)
        {
            Console.WriteLine("You owe " + item.Price);
            Console.WriteLine("Check Amount: ");

            int checkamount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for the check. We have a processed your payment. Enjoy!");
        }
    }
}
