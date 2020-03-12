using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus
{
    public class PnjMenuHandler
    {

        public static PnjMenuHandler instance;
        public List<PnjMenuItem> menuItems;

        private PnjMenuHandler() { menuItems = new List<PnjMenuItem>(); }

        public static PnjMenuHandler getInstance()
        {
            if(PnjMenuHandler.instance == null)
            {
                PnjMenuHandler.instance = new PnjMenuHandler();
            }
            return PnjMenuHandler.instance;
        }

        public void returnToMenu()
        {
            showChoices();
        }

        public void addItemToMenu(PnjMenuItem menuItem)
        {
            if (!menuItems.Contains(menuItem))  menuItems.Add(menuItem);
        }

        private void showChoices()
        {
            int i = 1;
            foreach(PnjMenuItem item in menuItems)
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
            Console.WriteLine("Je n'ai pas compris votre réponse merci de choisir un nombre entre 1 et " + menuItems.Count);
            System.Threading.Thread.Sleep(1000);
            returnToMenu();
        }
    }
}
