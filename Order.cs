using System;
namespace TheBreakfastClub
{
    public class Order
    {
        List<Menu> order = new List<Menu>();

        public Order()
        {
            Console.WriteLine("Hello User! Welcome to the Breakfast Club!");
            Console.WriteLine("Have a look at our menu!");
        }


        public void PrintMenu(List<Menu> menus)
        {
            int i = 0;
            foreach (Menu n in menus)
            {

                Console.WriteLine(i++ + " " + n.Name);
            }
        }

        public void ItemDescription(List<Menu> item, int index)
        {
            Menu i = item[index];
            Console.WriteLine(i.Description);
        }

        public void quantity(Menu item)
        {

        }


    }
}
