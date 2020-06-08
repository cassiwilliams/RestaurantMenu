using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
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
        public static void AddItem(MenuItem newItem, Menu menu)
        {
            menu.MenuItems.Add(newItem);
        }
        public static void RemoveItem(MenuItem menuItem, Menu menu)
        {
            menu.MenuItems.Remove(menuItem);
        }
        public static void DisplayMenu(Menu menu)
        {
            for (int i = 0; i < menu.MenuItems.Count; i++) {
                MenuItem.DisplayItem(menu.MenuItems[i]);                
            }
            Console.WriteLine(menu.MenuItems.Count);
        }
    }
}
