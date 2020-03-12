using System;
using System.Collections.Generic;
using System.Text;

namespace TheWrathOfOrcus.Monsters
{
    public class SpiderSwarm : Monster
    {
        public SpiderSwarm()
        {
            this.name = "Swarm of Spiders";
            this.attack = 4;
            this.defense = 2;
            this.totalLifepoints = 10;
            this.actualLifepoints = this.totalLifepoints;
        }
    }
}
