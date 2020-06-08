using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        /*
         * MenuItems should be the class holding all the items price, description, and category, including the date (to match with date last modified), privately, and the date it was last modified
         */
        public string FoodName { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(string foodName, float price, string description, string category, bool isNew)
        {
            FoodName = foodName;
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }
        public static void DisplayItem(MenuItem menuItem)
        {
            Console.WriteLine(menuItem.FoodName);
            Console.WriteLine(menuItem.Price);
            Console.WriteLine(menuItem.Description);
            Console.WriteLine(menuItem.Category);
            if (menuItem.IsNew) {
                Console.WriteLine("New Item!!");
            }            
        }
    }
}
