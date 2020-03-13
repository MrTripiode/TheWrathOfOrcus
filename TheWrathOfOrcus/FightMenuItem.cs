using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;
using TheWrathOfOrcus.Monsters;

namespace TheWrathOfOrcus
{
    public abstract class FightMenuItem: MenuItem
    {
        public string name { get; set; }
        public Hero hero;
        public Fighter opponent;

        public abstract void ItemSelected();
    }

    public class AttackMenuItem : FightMenuItem
    {
        public AttackMenuItem(Hero hero, Fighter opponent)
        {
            this.name = "Attaquer";
            this.hero = hero;
            this.opponent = opponent;
        }


        public override void ItemSelected()
        {
            this.hero.attackTarget(this.opponent);
        }
    }
    public class FightInventoryMenuItem : FightMenuItem
    {
        public FightInventoryMenuItem(Hero hero, Fighter opponent)
        {
            this.name = "Inventaire";
            this.hero = hero;
            this.opponent = opponent;
        }


        public override void ItemSelected()
        {
            this.hero.inventory.showInventory();
        }
    }
}
