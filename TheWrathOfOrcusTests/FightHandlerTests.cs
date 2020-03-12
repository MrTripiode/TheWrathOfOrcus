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
            FightHandler fh = new FightHandler(living, dead);
            Assert.IsFalse(fh.continueFight());
        }

        [Test]
        public void testFightDoesntEndWhenOneFighterHasMoreThan0LifePoints()
        {
            Mocks.MockMonster living = new Mocks.MockMonster(0, 0, 10, null, null);
            Mocks.MockMonster living_bis = new Mocks.MockMonster(0, 0, 10, null, null);
            FightHandler fh = new FightHandler(living, living_bis);
            Assert.IsTrue(fh.continueFight());
        }

        [Test]
        public void playerGainGoldWhenWinsFight()
        {
            Hero hero = new Hero("Test");
            int heroGoldBeforeFight = hero.gold;
            Mocks.MockMonster deadMonster = new Mocks.MockMonster(0, 0, 0, new Tuple<int, int>(5,10), null);
            FightHandler fh = new FightHandler(hero, deadMonster);
            Assert.Greater(hero.gold, heroGoldBeforeFight);
        }
    }
}
