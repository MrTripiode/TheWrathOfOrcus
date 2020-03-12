using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus;

namespace TheWrathOfOrcusTests
{
    class FightHandlerTests
    {
        [Test]
        public void testFightEndsWhenOneFighterHas0LifePointsOrLess()
        {
            Mocks.MockMonster living = new Mocks.MockMonster(0, 0, 10, null, null);
            Mocks.MockMonster dead = new Mocks.MockMonster(0, 0, 0, null, null);
            Assert.IsFalse(FightHandler.continueFight(living, dead));
        }
    }
}
