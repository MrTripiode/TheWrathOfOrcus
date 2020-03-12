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
        public Inventory inventory { get; set; }
        public int gold { get; set; }

        public Hero(string name)
        {
            this.name = name;
            this.attack = 5;
            this.defense = 5;
            this.totalLifepoints = 50;
            this.actualLifepoints = totalLifepoints;
            this.level = 1;
            this.experience = 0;
            this.inventory = new Inventory();

        }

        public void heal(int amount)
        {
            if(amount <= 0)
            {
                return;
            }

            if(actualLifepoints + amount > totalLifepoints)
            {
                actualLifepoints = totalLifepoints;
            }
            else
            {
                actualLifepoints = actualLifepoints + amount;
            }
        }

        public void takeDamage(int damage)
        {
            throw new NotImplementedException();
        }

        public void attackTarget(Fighter target)
        {
            throw new NotImplementedException();
        }

        public void handleTurn(Fighter target)
        {
            throw new NotImplementedException();
        }
        public void getLootAndExp(Loot loot)
        {
            this.gold += loot.gold;
            this.experience += loot.experience;
            this.checkIfGainedLevel();
        }

        private void checkIfGainedLevel()
        {
            int threshold = (int)Math.Round(100 * (1 + 2 * level * 0.1), 0);
            if(this.experience >= threshold)
            {
                this.experience = this.experience - threshold;
                this.gainLevel();
            }
        }

        private void gainLevel()
        {
            this.level++;
            this.totalLifepoints += 10;
            this.actualLifepoints += 10;
        }

        internal void handleDeath()
        {
            throw new NotImplementedException();
        }
    }
}
