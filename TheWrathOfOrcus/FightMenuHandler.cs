using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus
{
    class FightMenuHandler
    {
        public static FightMenuHandler instance;
        public List<FightMenuItem> menuItems;
        public Fighter opponent;
        public Hero hero;

        private FightMenuHandler() { menuItems = new List<FightMenuItem>(); }

        public static FightMenuHandler getInstance()
        {
            if (FightMenuHandler.instance == null)
            {
                FightMenuHandler.instance = new FightMenuHandler();
            }
            return FightMenuHandler.instance;
        }

        public void addMenuItem(FightMenuItem item)
        {
            this.menuItems.Add(item);
        }

        public void showChoices()
        {
            int i = 1;
            Console.WriteLine("Un " + opponent.name + " est face à vous !");
            foreach (FightMenuItem item in menuItems)
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
            Console.WriteLine(choice);

            if (!(choice > 48 && choice < 49 + menuItems.Count))
            {
                Console.WriteLine("Le héros est perdu dans ses pensées et rate l'occasion d'agir. (1, " + menuItems.Count+")");
                System.Threading.Thread.Sleep(1000);
            } else
            {
                menuItems[choice - 49].ItemSelected();
            }
        }

        internal void resetMenuItems()
        {
            this.menuItems = new List<FightMenuItem>();
        }
    }
}
