using System;
using System.Collections.Generic;
using System.Collections;

namespace TheBreakfastClub
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Menu> view = new List<Menu>();

            Order order = new Order();

            Menu item1 = new Menu("Awesome Avocado", "Omellet", "", 0);
            Menu Item2 = new Menu("VEGGIE DELIGHT ", "Omellet", "", 10.30);
            Menu Item3 = new Menu("LEAN & GREEN", "Omellet", "", 13.00);
            Menu Item4 = new Menu("CHICKEN FAJITA ", "Fajita", "", 0);
            Menu Item5 = new Menu("JUMP START BREAKFAST SANDWICH ", "Sandwhich", "", 0);
            Menu Item6 = new Menu("The healthier English", "English Muffin", "", 0);
            Menu Item7 = new Menu("The happy American", "Snadwhich", "", 0);
            Menu Item8 = new Menu("Pancakes", "Buttermilk Pancakes", "", 0);
            Menu Item9 = new Menu("Parfait", "Yogurt", "", 0);
            Menu Item10 = new Menu("Tea", "Hot Tea", "", 0);
            Menu Item11 = new Menu("Orange Juice", "Cold Orange Juice", "", 0);
            Menu Item12 = new Menu("Coffee", "Dark Roasted Coffee", "", 0);

            view.Add(item1);
            view.Add(Item2);
            view.Add(Item3);
            view.Add(Item4);
            view.Add(Item5);
            view.Add(Item6);
            view.Add(Item7);
            view.Add(Item8);
            view.Add(Item9);
            view.Add(Item10);
            view.Add(Item11);
            view.Add(Item12);


            order.PrintMenu(view);

            Console.WriteLine("Which item would you like to know more about?");


            int input = Convert.ToInt32(Console.ReadLine());

            order.ItemDescription(view, input);

            Console.WriteLine("Would you like to order the " + view[input].Name + "?");


            string answer = Console.ReadLine();

            try
            {
                answer.ToLower().Trim();

                if (answer == "yes")
                {
                    Console.WriteLine("Awesome! The price is " + view[input].Price + " dollars");

                }
            }
            catch (InvalidCastException)
            {
                throw new Exception("Sorry, but you must enter a valid string.");
            }
            Payment process = new Payment(view[input]);


        }
    }
}
