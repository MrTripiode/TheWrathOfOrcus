using NUnit.Framework;
using TheWrathOfOrcus;
using TheWrathOfOrcusTests.Mocks;
namespace TheWrathOfOrcusTests
{
    class Inventorytests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestInventoryShouldAddElementToArmorsWhenArmorGiven()
        {
            MockArmor mockArmor = new MockArmor();
            Inventory inventory = new Inventory();
            inventory.addItemToInventory(mockArmor);
            Assert.AreEqual(1,inventory.armors.Count);
        }

        [Test]
        public void TestInventoryShouldAddElementToWeaponsWhenWeaponGiven()
        {
            MockWeapon mockWeapon = new MockWeapon();
            Inventory inventory = new Inventory();
            inventory.addItemToInventory(mockWeapon);
            Assert.AreEqual(1, inventory.weapons.Count);
        }

        [Test]
        public void TestInventoryShouldAddElementToItemsWhenItemGiven()
        {
            MockItem mockItem = new MockItem();
            Inventory inventory = new Inventory();
            inventory.addItemToInventory(mockItem);
            Assert.AreEqual(1, inventory.items.Count);
        }
    }
}
