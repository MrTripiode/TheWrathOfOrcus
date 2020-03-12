using System;
using System.Collections.Generic;
using System.Text;

namespace TheWrathOfOrcus.Monsters
{
    public class SpiderSwarm : Monster
    {
        public SpiderSwarm()
        {
            this.name = "Essaim d'Araignées";
            this.attack = 4;
            this.defense = 2;
            this.totalLifepoints = 10;
            this.actualLifepoints = this.totalLifepoints;
            this.loot = new Loot(10, 10);
        }
    }
}
