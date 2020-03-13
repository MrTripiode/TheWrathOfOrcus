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

        private void reset() {
            Console.Clear();
            Console.WriteLine("Le héros est perdu dans ses pensées et rate l'occasion d'agir. (1, " + menuItems.Count+")");
            System.Threading.Thread.Sleep(1000);
        }

        internal void resetMenuItems()
        {
            this.menuItems = new List<FightMenuItem>();
        }
    }
}
