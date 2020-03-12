using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus
{
    public class InventoryMenuItem : MenuItem
    {
        public string name { get; set; }

        public InventoryMenuItem(string name)
        {
            this.name = name;
        }
        public void ItemSelected()
        {
            MenuHandler.getInstance().hero.inventory.showInventory();
            Console.Out.Flush();
            Console.Read();
            MenuHandler.getInstance().returnToMenu();
        }
    }
}