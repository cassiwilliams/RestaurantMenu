using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        /*
         * Menu should include current date, display items, and ability to input new items and pass it to the menu items class list/dictionary
         */
        public List<MenuItem> MenuItems { get; set; }
        public DateTime MenuDateTime { get; }
        public Menu(List<MenuItem> item, DateTime updateDate)
        {
            MenuItems = item;
            MenuDateTime = updateDate;
        }
    }
}
