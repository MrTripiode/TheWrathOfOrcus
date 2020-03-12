using System;
using System.Collections.Generic;
using System.Text;
using TheWrathOfOrcus.Interfaces;

namespace TheWrathOfOrcus
{
    public class Pnj : Fighter
    {
        public string name { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int totalLifepoints { get; set; }
        public int actualLifepoints { get; set; }
        public Quest quest { get; }

        public Pnj(string name, int attack, int defense, int totalLifepoints, Quest quest) {
            this.name = name;
            this.attack = attack;
            this.defense = defense;
            this.totalLifepoints = totalLifepoints;
            this.actualLifepoints = this.totalLifepoints;
            this.quest = quest;
        }

        public void talk(Hero hero) {
            Console.Clear();
            Console.WriteLine("Bonjour ! " + hero.name);
            Console.WriteLine("Je suis " + this.name + ", j'ai besoin d'aide !");
            Console.WriteLine("Acceptes tu " + this.quest.name + " ?");
            Console.WriteLine("Il te faudra ..." + quest.description +
                              "( Difficulté: " + this.quest.difficulty +
                              ", nombre de monstres: " + this.quest.monsters.Count + ")");
        }

        public void makeAchoice(Hero hero) {
            this.talk(hero);
            PnjMenuItem accept = new PnjMenuItem("Accepter", this, hero);
            PnjMenuItem deny = new PnjMenuItem("Refuser", this, hero);
            PnjMenuHandler.getInstance().addItemToMenu(accept);
            PnjMenuHandler.getInstance().addItemToMenu(deny);

            PnjMenuHandler.getInstance().returnToMenu();
        }

        public void launchQuest(Hero hero) {
            foreach (var monster in this.quest.monsters)
            {
                FightHandler fightHandler = new FightHandler(hero, monster);
                fightHandler.startFight();
            }
        }

        public void attackTarget(Fighter target)
        {
            throw new NotImplementedException();
        }

        public void handleTurn(Fighter target)
        {
            throw new NotImplementedException();
        }

        public void takeDamage(int damage)
        {
            throw new NotImplementedException();
        }
    }
}
