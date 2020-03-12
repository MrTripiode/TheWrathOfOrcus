using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus.Monsters
{
    public abstract class Monster : Fighter
    {
        public string name { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int totalLifepoints { get; set; }
        public int actualLifepoints { get; set; }
        public Loot loot { get; set; }

        public void takeDamage(int damage)
        {
            if(damage < 0)
            {
                throw new ArgumentException("Fighters can't take negative damages");
            }
            this.actualLifepoints = this.actualLifepoints - damage;
        }

        public void attackTarget(Fighter target)
        {
            int damage = this.attack - target.defense;
            damage = damage >= 0 ? damage : 0;
            Console.ForegroundColor = ConsoleColor.Red;
            target.takeDamage(damage);
            Console.WriteLine("-" + damage + "PV");
            Console.WriteLine(target.name + ": "+target.actualLifepoints+"/"+target.totalLifepoints+"PV");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void handleTurn(Fighter target)
        {
            Console.WriteLine(this.name + " attaque " + target.name + "!");
            this.attackTarget(target);
        }
    }
}
