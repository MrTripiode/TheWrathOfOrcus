using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus
{
    public class Inventory
    {
        public List<Item> items;
        public List<Weapon> weapons;
        public List<Armor> armors;

        public Inventory()
        {
            items = new List<Item>();
            weapons = new List<Weapon>();
            armors = new List<Armor>();


        }

        public void addItemToInventory(Item item)
        {
            if(item is Armor)
            {
                armors.Add(item as Armor);
            }
            else if (item is Weapon)
            {
                weapons.Add(item as Weapon);
            }
            else
            {
                items.Add(item);
            }
        }

        public void showInventory()
        {
            Console.Clear();
            Console.WriteLine("Armes : ");
            foreach(Weapon weapon in weapons)
            {
                Console.WriteLine("- " + weapon.name + " -> " + weapon.itemAttack + " Atk");
            }
            Console.WriteLine("Armures : ");
            foreach (Armor armor in armors)
            {
                Console.WriteLine("- " + armor.name + " -> " + armor.itemDefence
                    + " Def");
            }
            Console.WriteLine("Objets : ");
            foreach (Item item in items)
            {
                Console.WriteLine("- " + item.name);
            }
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
