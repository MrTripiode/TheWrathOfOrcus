
using NUnit.Framework;
using TheWrathOfOrcus;
using System.Diagnostics;

namespace TheWrathOfOrcusTests
{
    public class QuestsTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void QuestCreation()
        {
            Loot loot = new Loot(29, 30);
            Debug.WriteLine("OUI");
            Quest quest = new Quest("TestQuest", "Awesome Quest to do", 3, loot);
            Assert.AreEqual(quest.name, "TestQuest");
            Assert.AreEqual(quest.description, "Awesome Quest to do");
            Assert.AreEqual(quest.difficulty, 3);
            Assert.AreEqual(quest.loot, loot);
            Assert.AreEqual(quest.monsters.Count, 6);
        }
    }
}
