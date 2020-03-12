using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus
{
    public class PnjMenuItem : MenuItem
    {
        public string name { get; set; }
        Pnj associatedPnj { get; }
        Hero hero { get; }

        public PnjMenuItem(string name, Pnj pnj, Hero hero) {
            this.name = name;
            this.associatedPnj = pnj;
            this.hero = hero;
        }
        public void ItemSelected() {
            if (this.name == "Accepter") {
                this.associatedPnj.launchQuest(hero);
            } else if (this.name == "Refuser") {
                MenuHandler.getInstance().returnToMenu();
            }
        }
    }
}
