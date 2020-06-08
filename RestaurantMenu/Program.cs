using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MenuItem sampleItem = new MenuItem ("Pizza", 5.99f, "Delicious crust with sauce", "Entree", true);
            MenuItem sampleItem2 = new MenuItem("Hot Dog", 5.99f, "Delicious All-Beef Hot Dog", "Entree", false);
            List<MenuItem> menuList = new List<MenuItem>();
            Menu sampleMenu = new Menu(menuList, DateTime.Now);
            Menu.AddItem(sampleItem, sampleMenu);
            Menu.AddItem(sampleItem2, sampleMenu);

            //Console.WriteLine(sampleMenu.MenuItems[0].FoodName);
            //Console.WriteLine(sampleItem.FoodName);
            //MenuItem.DisplayItem(sampleItem);
            Menu.DisplayMenu
        }
        
    }
}
