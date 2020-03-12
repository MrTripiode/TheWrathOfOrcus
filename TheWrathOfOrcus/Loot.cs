﻿using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus
{
    public class Loot
    {
        int gold { get; }
        int experience { get; }
        List<Item> items { get; }
        public Loot(int gold, int experience)
        {
            this.gold = gold;
            this.experience = experience;
        }
    }
}