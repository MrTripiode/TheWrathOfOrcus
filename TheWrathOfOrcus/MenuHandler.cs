﻿using System;
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
                Console.WriteLine(i + ") "+item.name);
                i++;
            }
            Console.WriteLine("Choix : ("+ (menuItems.Count-1) + "-" + menuItems.Count+")");
            handleInputs();
        }

        private void handleInputs()
        {
            int choice = Console.Read();
            
            if(!(choice >47 && choice < 48 + menuItems.Count))
            {
                Console.Clear();
                Console.WriteLine("Je n'ai pas compris votre réponse merci de choisir un nombre entre "+ (menuItems.Count - 1) + " et " + menuItems.Count);
                System.Threading.Thread.Sleep(1000);
                returnToMenu();
            }

            menuItems[choice].ItemSelected();
        }


    }
}
