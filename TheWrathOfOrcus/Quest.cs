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

        List<Monster> monsters { get; }

        public Quest(String name, String description, int difficulty) {
            throw new NotImplementedException("Not implemented.");
        }
    }
}
