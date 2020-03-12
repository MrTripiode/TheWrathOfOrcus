using System;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcusTests.Mocks
{
    class MockArmor : Armor
    {
        public int itemDefence { get; set; }
        public string name { get; set; }

        public void use()
        {
            throw new NotImplementedException();
        }

        public MockArmor()
        {
            itemDefence = 5;
            name = "Le dos de Josué";
        }
    }
}
