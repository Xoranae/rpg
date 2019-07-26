using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace shadow_hunter
{
    class Program
    {

        


        // ------------------------ Jet de dés -------------------------------- //
        
        public static int Random(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public int JetDesMove()
        {
            return JetDes4() + JetDes6();
        }

        public int JetDes
        {
            get
            {
                int des4 = JetDes4();
                int des6 = JetDes6();

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
        }

        public int JetDes4()
        {
            
            return Random(1, 4);
        }

        public int JetDes6()
        {
            return Random(1, 6);
        }

        // ------------------------------------------------------------------------------------

        public static List<Character> PartyCharacters { get; set; }


        public static void RandomAttributionCharacters(int nbplayer)
        {
            PartyCharacters = new List<Character>();

            Character.Characters_generation(nbplayer);

            switch (nbplayer)
            {
                // 2 Shadows + 2 Hunters
                case 4:
                    for (int i = 0; i < 2; i++)
                    {
                        int n = Random(0, (Character.HunterCharacters.Count - 1));
                        PartyCharacters.Add(Character.HunterCharacters[n]);
                        Character.HunterCharacters.RemoveAt(n);
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        int n = Random(0, (Character.ShadowCharacters.Count - 1));
                        PartyCharacters.Add(Character.ShadowCharacters[n]);
                        Character.ShadowCharacters.RemoveAt(n);
                    }
                    break;

            }
        }


        public static void Main()
        {
            img.DisplayBegin(); // Dessin ASCII SHADOW HUNTERS

            int a = Player.ValidNumberPlayer();
            Console.WriteLine("La partie sera composée de " + a + " joueurs."); // Annonce du nombre de joueurs
            RandomAttributionCharacters(a);
            int i = 0;
            while( i < 15)
            {
                RandomAttributionCharacters(a);
                foreach (Character character in PartyCharacters)
                {
                    Console.WriteLine(character._name);
                    Console.WriteLine("");
                }
                i++;
            }
            
            

            World.Worldgeneration();
        }


    }
}
