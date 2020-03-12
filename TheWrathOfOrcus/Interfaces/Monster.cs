using System;
using System.Collections.Generic;
using System.Text;

namespace TheWrathOfOrcus.Interfaces
{
    interface Monster : Fighter
    {
        Loot loot { get; }
    }
}
