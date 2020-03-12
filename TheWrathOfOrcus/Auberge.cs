using System;
using System.Collections.Generic;
using System.Text;

namespace TheWrathOfOrcus
{
    public static class Auberge
    {
        public static int healPower = 10;
        public static int price = 10;
        public static void healHero(Hero hero)
        {
            hero.heal(healPower);
        }

        public static void greet(Hero hero)
        {
            Console.Clear();
            Console.WriteLine("Bonjour " + hero.name + ", bienvenue dans ma taverne !");
            Console.WriteLine("Le cout de la nuit est de " + price + "G");
            Console.WriteLine("Souhaitez-vous vous reposer ? Y/N");
            string choice = Console.ReadLine();
            if(choice != "Y" && choice != "N")
            {
                Console.WriteLine("Je n'ai pas compris votre réponse merci de choisir Y ou N");
                System.Threading.Thread.Sleep(1000);
                greet(hero);
            }

            if(choice == "Y")
            {
                healHero(hero);
            }
            else
            {
                Console.WriteLine("D'accord ! A plus tard alors " + hero.name);
            }

        }

    }
}
