
using NUnit.Framework;
using TheWrathOfOrcus;
using TheWrathOfOrcus.Monsters;

namespace TheWrathOfOrcusTests
{
    public class QuestsTests
    {
        [Test]
        public void QuestCreation()
        {
            Loot loot = new Loot(29, 30);
            Quest quest = new Quest("TestQuest", "Awesome Quest to do", 3, loot);
            Assert.AreEqual(quest.name, "TestQuest");
            Assert.AreEqual(quest.description, "Awesome Quest to do");
            Assert.AreEqual(quest.difficulty, 3);
            Assert.AreEqual(quest.loot, loot);
            Assert.AreEqual(quest.monsters.Count, 6);
        }
        [Test]
        public void QuestSuccess() {
            Loot loot = new Loot(29, 30);
            Quest quest = new Quest("TestQuest", "Awesome Quest to do", 1, loot);
            Assert.False(quest.IsSuccess());
        }
        [Test]
        public void QuestMonsterKilled() {
            Loot loot = new Loot(29, 30);
            Quest quest = new Quest("TestQuest", "Awesome Quest to do", 1, loot);
            int monsterNumber = quest.monsters.Count;
            Monster firstMonster = quest.monsters[0];
            quest.KillMonster();
            Assert.AreEqual(quest.monsters.Count, monsterNumber - 1);
            Assert.AreNotEqual(quest.monsters[0], firstMonster);
        }
    }
}
