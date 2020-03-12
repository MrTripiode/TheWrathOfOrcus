using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus
{
    class MenuHandler 
    {

        public static MenuHandler instance;
        List<MenuItem> menuItems;

        public MenuHandler getInstance()
        {
            if(MenuHandler.instance == null)
            {
                MenuHandler.instance = new MenuHandler();
            }
            return MenuHandler.instance;
        }

        public void addItemToMenu()
        {

        }


    }
}
