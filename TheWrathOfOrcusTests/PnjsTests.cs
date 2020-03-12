
using NUnit.Framework;
using TheWrathOfOrcus;

namespace TheWrathOfOrcusTests
{
    public class PnjsTests
    {
        [Test]
        public void PnjCreationTest() {
            Loot loot = new Loot(29, 30);
            Quest quest = new Quest("Awesome quest", "super hard to do", 2, loot);
            Pnj pnj = new Pnj("TEST", 10, 10, 100, quest);

            Assert.AreEqual(pnj.name, "TEST");
            Assert.AreEqual(pnj.attack, 10);
            Assert.AreEqual(pnj.defense, 10);
            Assert.AreEqual(pnj.actualLifepoints, 100);
            Assert.AreEqual(pnj.totalLifepoints, 100);
            Assert.AreEqual(pnj.quest, quest);
        }
    }
}
