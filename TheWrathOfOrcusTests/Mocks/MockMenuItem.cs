using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcusTests.Mocks
{
    class MockMenuItem : MenuItem
    {
        public string name { get; set; }

        public void ItemSelected()
        {
            throw new NotImplementedException();
        }

        public MockMenuItem()
        {
            name = "Auberge";
        }
    }
}
