﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheWrathOfOrcus.Interfaces
{
    public interface MenuItem
    {
        string name { get; set; }

        public void ItemSelected();
        
    }
}
