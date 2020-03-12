using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus.Items.Weapons
{
    class AntoineStick : Weapon
    {
        public int itemAttack { get; set; }
        public string name { get; set; }

        public void use()
        {
            throw new NotImplementedException();
        }

        public AntoineStick()
        {
            name = "Antoine epic stick";
            itemAttack = 100000;
        }
    }
}
