using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Monsters;
using TheWrathOfOrcusTests.Mocks;

namespace TheWrathOfOrcusTests
{
    class MonstersTests
    {
        [Test]
        public void testMonstersLoseTheGoodAmountOfLifePointsWhenTakingDamage()
        {
            Monster mockMonster = new MockMonster(0, 0, 10, null, null);
            int damage = 5;
            mockMonster.takeDamage(damage);
            Assert.AreEqual(mockMonster.totalLifepoints - damage, mockMonster.actualLifepoints);
        }

        [Test]
        public void testMonstersCantTakeNegativeDamages()
        {
            Monster mockMonster = new MockMonster(0, 0, 10, null, null);
            int damage = -5;
            Assert.Throws<ArgumentException>(delegate { mockMonster.takeDamage(damage); });
        }

        [Test]
        public void testMonstersCanAttackOtherFightersAndInflictCorrectDamages()
        {
            Monster attacker = new MockMonster(10, 0, 10, null, null);
            Monster target = new MockMonster(0, 5, 20, null, null);
            attacker.attackTarget(target);
            Assert.AreEqual(target.totalLifepoints - (attacker.attack - target.defense), target.actualLifepoints);
        }
    }
}
