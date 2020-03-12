using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus
{
    class FightHandler
    {
        Tuple<Fighter, Fighter> fighters;
        public FightHandler(Fighter fighter1, Fighter fighter2)
        {
            fighters = new Tuple<Fighter, Fighter>(fighter1, fighter2);
        }

        private void nextTurn(Fighter active, Fighter target)
        {
            active.handleTurn(target);
            if (continueFight())
            {
                this.nextTurn(target, active);
            }
        }

        bool continueFight()
        {
            return true;
        }
    }
}
