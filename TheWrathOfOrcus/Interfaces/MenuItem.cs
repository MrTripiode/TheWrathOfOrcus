using System;
using System.Collections.Generic;
using System.Text;

namespace TheWrathOfOrcus.Interfaces
{
    interface MenuItem
    {
        string name { get; set; }

        public void ItemSelected();
        
    }
}
