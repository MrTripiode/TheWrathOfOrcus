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

        public PnjMenuItem(string name, Pnj pnj) {
            this.name = name;
            this.associatedPnj = pnj;
        }
        public void ItemSelected() {
            if (this.name == "Accepter") {
                this.associatedPnj.launchQuest();
            } else if (this.name == "Refuser") {
                MenuHandler.getInstance().returnToMenu();
            }
        }
    }
}
