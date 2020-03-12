using NUnit.Framework;
using TheWrathOfOrcus;


namespace TheWrathOfOrcusTests
{
    class HeroTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestHeroShouldBeHealedBy2HP()
        {
            Hero hero = new Hero("Patate");
            hero.actualLifepoints = hero.actualLifepoints - 2;
            hero.heal(2);
            Assert.AreEqual(hero.totalLifepoints, hero.actualLifepoints);
        }

        [Test]
        public void TestHeroShouldNotAcceptHealByNegativeNumber()
        {
            Hero hero = new Hero("Patate");
            hero.actualLifepoints = hero.actualLifepoints - 2;
            hero.heal(-25);
            Assert.AreEqual(hero.totalLifepoints-2, hero.actualLifepoints);
        }

        [Test]
        public void TestHeroGainGoldWhenLooting()
        {
            Hero hero = new Hero("Patate");
            int playerOriginalGold = hero.gold;
            int lootedGold = 10;
            Loot loot = new Loot(lootedGold, 0);
            hero.getLootAndExp(loot);
            Assert.AreEqual(playerOriginalGold + lootedGold, hero.gold);
        }

        [Test]
        public void TestHeroGainExpWhenLooting()
        {
            Hero hero = new Hero("Patate");
            int playerOriginalExp = hero.experience;
            int lootedExp = 10;
            Loot loot = new Loot(0, lootedExp);
            hero.getLootAndExp(loot);
            Assert.AreEqual(playerOriginalExp + lootedExp, hero.experience);
        }

        [Test]
        public void testHeroGainLevelWhenAtExpThreshold()
        {
            Hero hero = new Hero("Patate");
            int playerOriginalExp = hero.experience;
            int lootedExp = 120;
            Loot loot = new Loot(0, lootedExp);
            hero.getLootAndExp(loot);
            Assert.AreEqual(2, hero.level);
        }
    }
}
