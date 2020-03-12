using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus
{
    class Pnj : Fighter
    {
        public string name { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int totalLifepoints { get; set; }
        public int actualLifepoints { get; set; }
        List<Quest> quests { get; }
    }
}
