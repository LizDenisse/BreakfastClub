    using System;
    using System.Collections.Generic;
    using System.Text;

namespace BreakfastClub

    {
        public class Order
        {
        List<Menu> menus = Menu.MenuItems();
        List<MenuItem> items = new List<MenuItem>();
            public Order()
            {
                Console.WriteLine("Hello User! Welcome to the Breakfast Club! Home of the best burgers in town.");
                Console.WriteLine("Have a look at our menu!");
            }
            public MenuItem AddMenuItem()
        {
                menus.Add(items);

                return item;
            }
            public void PrintMenu()
            {
                int i = 0;
                     foreach (var n in menus)
                {
                    Console.WriteLine(i++ + ". " + n.ToString());
                }
            }
        }

       public class MenuItem
        {
        }
}
