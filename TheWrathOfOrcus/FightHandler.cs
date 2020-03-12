using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;
using TheWrathOfOrcus.Monsters;

namespace TheWrathOfOrcus
{
    public class FightHandler
    {
        Tuple<Fighter, Fighter> fighters;
        public FightHandler(Fighter fighter1, Fighter fighter2)
        {
            this.fighters = new Tuple<Fighter, Fighter>(fighter1, fighter2);
        }

        public void startFight()
        {
            Console.Clear();
            Console.WriteLine("Le combat commence !");
            Console.WriteLine(fighters.Item1.name + " affronte un " + fighters.Item2.name);
            this.nextTurn(fighters.Item1, fighters.Item2);
        }

        public void nextTurn(Fighter active, Fighter target)
        {
            active.handleTurn(target);
            if (this.continueFight())
            {
                this.nextTurn(target, active);
            } 
            else
            {
                this.handleEndOfFight(target, active);
            }
        }

        private void handleEndOfFight(Fighter fighter1, Fighter fighter2)
        {
            if (fighter1.actualLifepoints <= 0)
            {
                Console.WriteLine(fighter2.name + "à gagné !");
                this.handleWin(fighter2, fighter1);
            } 
            else if (fighter2.actualLifepoints <= 0)
            {
                Console.WriteLine(fighter2.name + " a gagné !");
                this.handleWin(fighter1, fighter2);
            }
        }

        public void handleWin(Fighter winner, Fighter loser)
        {
            if (winner.GetType() == typeof(Hero))
            {
                Hero hero = winner as Hero;
                Monster monster = loser as Monster;
                hero.getLoot(monster.loot);
            } 
            else if (loser.GetType() == typeof(Hero))
            {
                Hero hero = loser as Hero;
                Monster monster = winner as Monster;
                hero.handleDeath();
            }
            else
            {
                Console.WriteLine("Super combat de monstre !");
            }
        }

        public bool continueFight()
        {
            if(this.fighters.Item1.actualLifepoints <= 0 || this.fighters.Item2.actualLifepoints <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
