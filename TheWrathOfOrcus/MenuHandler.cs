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
        public Hero hero;

        private MenuHandler() { menuItems = new List<MenuItem>(); }

        public static MenuHandler getInstance()
        {
            if(MenuHandler.instance == null)
            {
                MenuHandler.instance = new MenuHandler();
            }
            return MenuHandler.instance;
        }

        public void returnToMenu()
        {
            showChoices();
        }

        public void addItemToMenu(MenuItem menuItem)
        {
            if (!menuItems.Contains(menuItem))  menuItems.Add(menuItem);
        }

        private void showChoices()
        {
            Console.Clear();
            Console.WriteLine("Bienvenue dans le village ! Que souhaitez vous faire ?");
            int i = 1;
            foreach(MenuItem item in menuItems)
            {
                Console.WriteLine(i + ") " + item.name);
                i++;
            }
            Console.WriteLine("Choix : (1-" + menuItems.Count + ")");
            handleInputs();
        }

        private void handleInputs()
        {
            int choice = Console.Read();

            if(!(choice > 48 && choice < 49 + menuItems.Count+1))
            {
                Console.Clear();
                Console.WriteLine("Je n'ai pas compris votre réponse merci de choisir un nombre entre 1 et " + menuItems.Count);
                System.Threading.Thread.Sleep(1000);
                returnToMenu();
            }

            menuItems[choice - 49].ItemSelected();
        }

        public void MenuItemBank(Hero hero) {
            this.hero = hero;
            MenuHandler.getInstance().addItemToMenu(new PnjMenuItem("Accepter"));
            MenuHandler.getInstance().addItemToMenu(new InventoryMenuItem("Voir votre inventaire"));
        }


    }
}
