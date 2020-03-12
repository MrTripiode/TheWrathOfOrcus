using System;
using System.Collections.Generic;
using System.Text;

namespace TheWrathOfOrcus.Interfaces
{
    public interface Fighter
    {
        string name { get; set; }
        int attack { get; set; }
        int defense { get; set; }
        int totalLifepoints { get; set; }
        int actualLifepoints { get; set; }

        void takeDamage(int damage);

        void attackTarget(Fighter target);
        void handleTurn(Fighter target);
    }
}
