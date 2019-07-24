using System;

namespace elo_class
{
    public class Program
    {
        static void Main(string[] args)
        {            
            player myplayer = new player("Rox");
            Console.WriteLine("bonjour " + myplayer._name + " tu es level " + myplayer._level.ToString());            
            ennemy myennemy = new ennemy("orc",1,10);
            Console.WriteLine("un ennemy est là c'est un " + myennemy._name);
            int votrejet = jetde();
            int jetMonstre = jetde();
            myennemy._life -= (votrejet - jetMonstre);

        }

        static int jetde()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }
    }
}
