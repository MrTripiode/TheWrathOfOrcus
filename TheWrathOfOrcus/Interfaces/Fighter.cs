using System;
using System.Collections.Generic;
using System.Text;

namespace TheWrathOfOrcus.Interfaces
{
    interface Fighter
    {
        string name { get; set; }
        int attack { get; set; }
        int defense { get; set; }
        int totalLifepoints { get; set; }
        int actualLifepoints { get; set; }

        void takeDamage(int damage)
        {

        }
    }
}
