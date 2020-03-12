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
        public AttackMenuItem(Hero hero, Fighter monster)
        {
            this.name = "Attaquer";
            this.hero = hero;
            this.opponent = monster;
        }

        public override void ItemSelected()
        {
            this.hero.attackTarget(this.opponent);
        }
    }
}
