using System;

namespace TheWrathOfOrcus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour aventurier ! Quel est votre nom ?");
            Hero hero = new Hero(Console.ReadLine());
            MenuHandler.getInstance().returnToMenu();
        }
    }
}
