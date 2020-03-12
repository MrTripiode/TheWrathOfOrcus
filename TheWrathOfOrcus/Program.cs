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
            MenuHandler.getInstance().MenuItemBank(hero);
            MenuHandler.getInstance().returnToMenu();
            FightHandler fh = new FightHandler(new SpiderSwarm(), new SpiderSwarm());
            fh.startFight();
            Loot loot = new Loot(500, 500);
            Quest quest = new Quest("La colère des orcs", "Exploser beaucoup trop d'araignées en fait... ", 1, loot);
            Pnj mainPnj = new Pnj("Esteban", 100, 1000, 1000, quest);
            mainPnj.makeAchoice(hero);
            // MenuHandler.getInstance().returnToMenu();
        }
    }
}
