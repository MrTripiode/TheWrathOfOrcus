using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus
{
    public class MenuHandler 
    {

        public static MenuHandler instance;
        public List<MenuItem> menuItems;

        private MenuHandler() { menuItems = new List<MenuItem>(); }

        public static MenuHandler getInstance()
        {
            if(MenuHandler.instance == null)
            {
                MenuHandler.instance = new MenuHandler();
            }
            return MenuHandler.instance;
        }

        public void addItemToMenu(MenuItem menuItem)
        {
            if (!menuItems.Contains(menuItem))  menuItems.Add(menuItem);
        }


    }
}
