using System;
using System.Collections.Generic;

namespace BreakfastClub
{
    public class Menu
    {

        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double price { get; set; }

        static public List<Menu> MenuItems()
        {
            Menu item1 = new Menu()
            {
                Name = "Awesome Avocado ",
                Category = "Omellet",
                Description = "Stuffed with ripe avocado, lean turnkey bacon, bell pepper, a blend of Monterey Jack and Cheddar cheeses. Served with our homemade salsa.",
                price = 13.50
            };

            Menu Item2 = new Menu()
            {
                Name = "VEGGIE DELIGHT ",
                Category = "",
                Description = "",
                price = 10.30
            };
            Menu Item3 = new Menu()
            {
                Name = "LEAN & GREEN",
                Category = "",
                Description = "",
                price = 13.00
            };
            Menu Item4 = new Menu()
            {
                Name = "CHICKEN FAJITA ",
                Category = "",
                Description = "",
                price = 0
            };
            Menu Item5 = new Menu()
            {
                Name = "JUMP START BREAKFAST SANDWICH ",
                Category = "",
                Description = "",
                price = 0
            };
            Menu Item6 = new Menu()
            {
                Name = "The Helthier English ",
                Category = "",
                Description = "",
                price = 0
            };
            Menu Item7 = new Menu()
            {
                Name = "The Happy American ",
                Category = "",
                Description = "",
                price = 0
            };
            Menu Item8 = new Menu()
            {
                Name = "Pancakes ",
                Category = "",
                Description = "",
                price = 0
            };
            Menu Item9 = new Menu()
            {
                Name = "Parfait ",
                Category = "",
                Description = "",
                price = 0
            };
            Menu Item10 = new Menu()
            {
                Name = "Tea ",
                Category = "",
                Description = "",
                price = 0
            };

            Menu Item11 = new Menu()
            {
                Name = "Orange Juice ",
                Category = "",
                Description = "",
                price = 0
            };

            Menu Item12 = new Menu()
            {
                Name = "Coffee ",
                Category = "",
                Description = "",
                price = 0
            };


            List<Menu> menu = new List<Menu>();

            menu.Add(item1);
            menu.Add(Item2);
            menu.Add(Item3);
            menu.Add(Item4);
            menu.Add(Item5);
            menu.Add(Item6);
            menu.Add(Item7);
            menu.Add(Item8);
            menu.Add(Item9);
            menu.Add(Item10);
            menu.Add(Item11);
            menu.Add(Item12);

            return menu;


        }



        //public void PrintMenu()

        //{
        //    var items = Menu.MenuItems();
        //    var i = 0;

        //    foreach (var item in items)
        //    {
        //        Console.WriteLine(i+""+item);
        //        i++;
        //    }
        //}


    }
}
