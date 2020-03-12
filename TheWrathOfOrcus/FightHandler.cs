using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus
{
    public class FightHandler
    {
        public FightHandler(Fighter fighter1, Fighter fighter2)
        {
            Console.Clear();
            this.nextTurn(fighter1, fighter2);
        }

        private void nextTurn(Fighter active, Fighter target)
        {
            active.handleTurn(target);
            if (continueFight(active, target))
            {
                this.nextTurn(target, active);
            }
        }

        public static bool continueFight(Fighter fighter1, Fighter fighter2)
        {
            return true;
        }
    }
}
