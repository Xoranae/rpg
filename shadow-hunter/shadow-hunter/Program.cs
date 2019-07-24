using System;
using System.Collections.Generic;

namespace shadow_hunter
{
    class Program
    {


        // ------------------------ Jet de dés -------------------------------- //
        public int jetdesMove()
        {
            return jetdes4() + jetdes6();
        }

        public int jetdes()
        {
            int des4 = jetdes4();
            int des6 = jetdes6();

            if (des6 > des4)
            {
                return des6 - des4;
            }
            else if (des6 == des4)
            {
                return 0;
            }
            else
            {
                return des4 - des6;
            }
        }

        public int jetdes4()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }

        public int jetdes6()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }

        // ------------------------------------------------------------------------------------

        static void Main(string[] args)
        {
            
            

            List<character> characters = new List<character>();
            character.init();
            characters.Add(new character("Loup-Garou",character.teams[1], 14, "contre-attack", "lolilol"));

            Console.WriteLine("Tu es " + characters[0]._name);
            Console.WriteLine("Tu es un " + characters[0]._team);
            Console.ReadLine();
        }

    }
}
