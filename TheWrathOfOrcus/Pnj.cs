using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus
{
    public class Pnj : Fighter
    {
        public string name { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int totalLifepoints { get; set; }
        public int actualLifepoints { get; set; }
        public Quest quest { get; }

        public Pnj(string name, int attack, int defense, int totalLifepoints, Quest quest) {
            this.name = name;
            this.attack = attack;
            this.defense = defense;
            this.totalLifepoints = totalLifepoints;
            this.actualLifepoints = this.totalLifepoints;
            this.quest = quest;
        }

        public void attackTarget(Fighter target)
        {
            throw new NotImplementedException();
        }

        public void takeDamage(int damage)
        {
            throw new NotImplementedException();
        }

        public void handleTurn(Fighter target)
        {
            throw new NotImplementedException("NO NEED HERE");
        }
    }
}
