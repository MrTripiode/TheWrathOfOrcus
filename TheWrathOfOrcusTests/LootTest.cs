using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus;

namespace TheWrathOfOrcusTests
{
    class LootTest
    {
        [Test]
        public void testLootGenerateRandomGoldValueFromRange()
        {
            Tuple<int, int> goldRange = new Tuple<int, int>(5, 10);
            Tuple<int, int> expRange = new Tuple<int, int>(0, 0);
            Loot loot = new Loot(goldRange, expRange);
            Assert.IsTrue(loot.gold >= 5 && loot.gold <= 10);
        }

        [Test]
        public void testLootGenerateRandomExpValueFromRange()
        {
            Tuple<int, int> goldRange = new Tuple<int, int>(0, 0);
            Tuple<int, int> expRange = new Tuple<int, int>(5, 10);
            Loot loot = new Loot(goldRange, expRange);
            Assert.IsTrue(loot.experience >= 5 && loot.experience <= 10);
        }
    }
}
