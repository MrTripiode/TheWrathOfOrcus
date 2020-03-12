using System;
using System.Collections.Generic;
using System.Text;

namespace TheWrathOfOrcus.Interfaces
{
    public interface Weapon : Item
    {
        public int itemAttack { get; set; }
    }
}
