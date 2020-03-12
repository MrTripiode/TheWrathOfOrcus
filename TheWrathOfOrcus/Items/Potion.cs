using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus.Items
{
    class Potion : Item
    {
        public string name { get; set; }
        public int healPower { get; set; }

        public Potion(int healPower)
        {
            this.name = "Potion de soin 25 hp";
            this. healPower = healPower;
        }

        public void use()
        {
            MenuHandler.getInstance().hero.heal(healPower);
        }
    }
}
