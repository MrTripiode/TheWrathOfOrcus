using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Monsters;

namespace TheWrathOfOrcusTests.Mocks
{
    class MockMonster: Monster
    {
        public MockMonster(int attack, int defense, int lifepoints, int gold, int experience)
        {
            this.name = "MockMonster";
            this.attack = attack;
            this.defense = defense;
            this.totalLifepoints = lifepoints;
            this.actualLifepoints = lifepoints;
            this.loot = new TheWrathOfOrcus.Loot(gold, experience);
        }
    }
}
