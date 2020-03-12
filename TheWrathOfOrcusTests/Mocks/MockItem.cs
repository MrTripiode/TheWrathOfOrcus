using System;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcusTests.Mocks
{
    class MockItem : Item
    {
        public string name { get; set; }

        public void use()
        {
            throw new NotImplementedException();
        }

        public MockItem()
        {
            name = "Potion des dieux";
        }
    }
}
