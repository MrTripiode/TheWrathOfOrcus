﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheWrathOfOrcus.Interfaces
{
    public interface Item
    {
        public string name { get; set; }

        public void use();
    }
}
