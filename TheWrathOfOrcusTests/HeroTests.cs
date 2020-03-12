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
            Assert.AreEqual(hero.totalLifepoints, hero.actualLifepoints);
        }
    }
}
