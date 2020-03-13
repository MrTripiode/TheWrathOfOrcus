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
        public int experience { get; set; }
        public int level { get; set; }
        public int gold { get; private set; }

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
            this.inventory.addStartingItems();

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
            // Decrease damage from armor
            this.actualLifepoints -= damage;
        }

        public void attackTarget(Fighter target)
        {
            Console.WriteLine(this.name + " attaque " + target.name + "!");
            // Add attack due to weapon
            int damage = this.attack - target.defense;
            damage = damage >= 0 ? damage : 0;
            Console.ForegroundColor = ConsoleColor.Red;
            target.takeDamage(damage);
            Console.WriteLine("-" + damage + "PV");
            Console.WriteLine(target.name + ": " + target.actualLifepoints + "/" + target.totalLifepoints + "PV");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void handleTurn(Fighter target)
        {
            FightMenuHandler fmh = FightMenuHandler.getInstance();
            fmh.resetMenuItems();
            fmh.addMenuItem(new AttackMenuItem(this, target));
            fmh.addMenuItem(new FightInventoryMenuItem(this, target));
            fmh.hero = this;
            fmh.opponent = target;
            fmh.showChoices();
        }
        public void getLootAndExp(Loot loot)
        {
            this.gold += loot.gold;
            this.experience += loot.experience;
            Console.WriteLine("Vous gagnez " + loot.gold + " pièces d'or et " + loot.experience + " points d'expérience !");
            foreach(Item item in loot.items)
            {
                Console.WriteLine("Vous trouvez: " + item.name);
                this.inventory.addItemToInventory(item);
            }
            this.checkIfGainedLevel();
        }

        private void checkIfGainedLevel()
        {
            int threshold = (int)Math.Round(100 * (1 + 2 * level * 0.1), 0);
            if(this.experience >= threshold)
            {
                this.experience = this.experience - threshold;
                this.gainLevel();
                this.printNewStats();
            }
        }

        private void printNewStats()
        {
            Console.WriteLine("Vous gagnez un niveau !");
            Console.WriteLine("Niv: " + this.level);
            Console.WriteLine("PV: " + this.totalLifepoints);
            Console.WriteLine("Att: " + this.attack);
            Console.WriteLine("Def: " + this.defense);
        }

        private void gainLevel()
        {
            this.level++;
            this.totalLifepoints += 10;
            this.actualLifepoints += 10;
            this.attack += 1;
            this.defense += 1;
        }

        internal void handleDeath()
        {
            Console.WriteLine("Tu as perdu !");
        }
    }
}
