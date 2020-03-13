using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus
{
    public class Loot
    {
        public int gold { get; }
        public int experience { get; }
        public List<Item> items { get; }
        public Loot(int gold, int experience)
        {
            this.gold = gold;
            this.experience = experience;
            this.items = new List<Item>();
        }

        public Loot(Tuple<int, int> goldRange, Tuple<int, int> expRange)
        {
            Random rand = new Random();
            this.gold = rand.Next(goldRange.Item1, goldRange.Item2);
            this.experience = rand.Next(expRange.Item1, expRange.Item2);
            this.items = new List<Item>();
        }

        public Loot(Tuple<int, int> goldRange, Tuple<int, int> expRange, List<Tuple<Item, int>> itemDrops)
        {
            Random rand = new Random();
            this.gold = rand.Next(goldRange.Item1, goldRange.Item2);
            this.experience = rand.Next(expRange.Item1, expRange.Item2);
            this.items = new List<Item>();
            foreach (Tuple<Item, int> itemDrop in itemDrops)
            {
                int diceRoll = rand.Next(1, 100);
                if(diceRoll <= itemDrop.Item2)
                {
                    items.Add(itemDrop.Item1);
                }
            }
        }
    }
}
