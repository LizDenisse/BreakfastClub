using System;
using System.Collections.Generic;

namespace BreakfastClub
{
    public class Menu
    {

        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Menu(string name, string description, String category, double price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Category = category;
        }
        static public List<Menu> MenuItems()
        {
            Menu item1 = new Menu("Awesome Avocado", "Omellet", "", 0);
            Menu Item2 = new Menu("Veggie Delight  ", "Omellet", "", 10.30);
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
        public override string ToString()
        {

            return "Iem" + ":" + Name +
                Description +
                Category +
                Price;
        }

    }
}