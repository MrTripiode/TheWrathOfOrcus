using NUnit.Framework;
using TheWrathOfOrcus;
using TheWrathOfOrcusTests.Mocks;

namespace TheWrathOfOrcusTests
{
    class MenuHandlerTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void testAddItemToItemListShouldReturnWhenAddingTheSameItemTwoTime()
        {
            MockMenuItem mockMenuItem = new MockMenuItem();
            MenuHandler menuHandler = MenuHandler.getInstance();
            menuHandler.addItemToMenu(mockMenuItem);
            menuHandler.addItemToMenu(mockMenuItem);
            Assert.AreEqual(1, menuHandler.menuItems.Count);
        }
    }
}
