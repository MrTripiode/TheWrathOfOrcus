using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Monsters;

namespace TheWrathOfOrcusTests.Mocks
{
    class MockMonster: Monster
    {
        public MockMonster(int attack, int defense, int lifepoints, Tuple<int, int> goldRange, Tuple<int, int> expRange)
        {
            this.name = "MockMonster";
            this.attack = attack;
            this.defense = defense;
            this.totalLifepoints = lifepoints;
            this.actualLifepoints = lifepoints;
            if(goldRange is null || expRange is null)
            {
                this.loot = new TheWrathOfOrcus.Loot(0, 0);
            }
            else
            {
                this.loot = new TheWrathOfOrcus.Loot(goldRange, expRange);
            }
        }
    }
}
