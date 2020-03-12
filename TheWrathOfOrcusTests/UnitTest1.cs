using NUnit.Framework;
using TheWrathOfOrcus;

namespace TheWrathOfOrcusTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void QuestCreation() {
            Quest quest = new Quest("TestQuest", "Awesome Quest to do", 3);
            Assert.AreEqual(quest.name, "TestQuest");
            Assert.AreEqual(quest.description, "Awesome Quest to do");
            Assert.AreEqual(quest.difficulty, 3);
        }
    }
}