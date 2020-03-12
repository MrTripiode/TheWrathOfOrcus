using System;
using TheWrathOfOrcus.Monsters;

namespace TheWrathOfOrcus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour aventurier ! Quel est votre nom ?");
            Hero hero = new Hero(Console.ReadLine());
            MenuHandler.getInstance().MenuItemBank();
            MenuHandler.getInstance().returnToMenu();
            FightHandler fh = new FightHandler(new SpiderSwarm(), new SpiderSwarm());
            fh.startFight();
        }
    }
}
