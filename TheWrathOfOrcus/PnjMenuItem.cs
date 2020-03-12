using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus
{
    public class PnjMenuItem : MenuItem
    {
        public string name { get; set; }

        public PnjMenuItem(string name) {
            this.name = name;
        }
        public void ItemSelected() {
            throw new NotImplementedException("C'est pas la");
            MenuHandler.getInstance().returnToMenu();
        }
    }
}
