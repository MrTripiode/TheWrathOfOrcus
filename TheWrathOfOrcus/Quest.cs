using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;
using TheWrathOfOrcus.Monsters;

namespace TheWrathOfOrcus
{
    public class Quest
    {
        public String name { get; }
        public String description { get; } // Storyline, quest description
        public int difficulty { get; }
        public Loot loot { get; }

        public List<Monster> monsters { get; }

        public Quest(String name, String description, int difficulty, Loot loot) {
            this.name = name;
            this.description = description;
            this.difficulty = difficulty;
            this.loot = loot;
            this.monsters = new List<Monster>();
            for (int i = 0; i < difficulty * 2; i++)
            {
                this.monsters.Add(new SpiderSwarm());
            }
        }

        public Boolean IsSuccess() {
            if (this.monsters.Count == 0) {
                return true;
            }
            return false;
        }

        public void KillMonster() {
            this.monsters.RemoveAt(0);
        }
    }
}
