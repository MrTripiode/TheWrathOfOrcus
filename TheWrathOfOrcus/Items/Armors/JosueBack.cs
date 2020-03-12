using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus.Items.Armors
{
    class JosueBack : Armor
    {
        public int itemDefence { get; set; }
        public string name { get; set; }

        public void use()
        {
            throw new NotImplementedException();
        }

        public JosueBack()
        {
            name = "Josue's back";
            itemDefence = 1000;
        }
    }
}
