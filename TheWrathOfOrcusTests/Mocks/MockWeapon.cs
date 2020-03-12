using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcusTests.Mocks
{
    class MockWeapon : Weapon
    {
        public int itemAttack { get; set; }
        public string name { get; set; }

        public void use()
        {
            throw new NotImplementedException();
        }

        public MockWeapon()
        {
            itemAttack = 5;
            name = "Le batonnet d'Antoine";
        }
    }
}
