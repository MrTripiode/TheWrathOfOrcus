using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus
{
    public class Hero : Fighter
    {
        public string name { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int totalLifepoints { get; set; }
        public int actualLifepoints { get; set; }
        int experience { get; set; }
        int level { get; set; }

        public Hero(String name)
        {
            this.name = name;
            this.attack = 5;
            this.defense = 5;
            this.totalLifepoints = 50;
            this.actualLifepoints = this.totalLifepoints;
            this.level = 1;
            this.experience = 0;

        }

        public void heal(int amount)
        {

        }

    }
}
