using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        /*
         * MenuItems should be the class holding all the items price, description, and category, including the date (to match with date last modified), privately, and the date it was last modified
         */
        public float Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(float price, string description, string category, bool isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }
    }
}
