﻿using NUnit.Framework;
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
            Monster mockMonster = new MockMonster(0,0,10,0,0);
            int damage = 5;
            mockMonster.takeDamage(damage);
            Assert.AreEqual(mockMonster.totalLifepoints - damage, mockMonster.actualLifepoints);
        }
    }
}
