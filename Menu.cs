using System;
using System.Collections.Generic;
using System.Text;

namespace TheBreakfastClub
{
    class Menu
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



        public override string ToString()
        {

            return "Iem" + ":" + Name +
                Description +
                Category +
                Price;
        }
    }
}
