using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;
using TheWrathOfOrcus.Items;

namespace TheWrathOfOrcus.Monsters
{
    public class SpiderSwarm : Monster
    {
        public SpiderSwarm()
        {
            this.name = "Essaim d'Araignées";
            this.attack = 8;
            this.defense = 2;
            this.totalLifepoints = 10;
            this.actualLifepoints = this.totalLifepoints;
            List<Tuple<Item, int>> itemDrops = new List<Tuple<Item, int>>();
            itemDrops.Add(new Tuple<Item, int>(new Potion(15), 10));
            this.loot = new Loot(new Tuple<int, int>(0,5), new Tuple<int, int>(10, 20));
        }
    }
}
