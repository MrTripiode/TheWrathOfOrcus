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
            int parsedChoice = 0;
            string choice = Console.ReadLine();
            if(!(Int32.TryParse(choice, out parsedChoice))) {
                this.reset();
            }

            if (parsedChoice < 0 || parsedChoice > (this.menuItems.Count)) {
                this.reset();
            }

            menuItems[parsedChoice - 1].ItemSelected();
        }

        public void reset() {
            Console.Clear();
            Console.WriteLine("Je n'ai pas compris votre réponse merci de choisir un nombre entre 1 et " + menuItems.Count);
            System.Threading.Thread.Sleep(1000);
            returnToMenu();
        }

        public void MenuItemBank(Hero hero) {
            this.hero = hero;
            MenuHandler.getInstance().addItemToMenu(new InventoryMenuItem("Voir votre inventaire"));
        }


    }
}
