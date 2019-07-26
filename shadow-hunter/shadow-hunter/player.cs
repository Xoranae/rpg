using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace shadow_hunter
{
    public class Player
    {
        public string _name { get; set; }
        public string _color { get; set; }
        public string _character { get; set; }
        public string _place { get; set; }

        private static bool ValidNumber(string arg)
        {
            System.Text.RegularExpressions.Regex myRegex = new Regex("^[0-9]{1}$");
            var val = myRegex.IsMatch(arg); // retourne true ou false selon la vérification
            return val;
        }

        static public int nberror = 0;

        public static int AskNbPlayer()
        {
            while (true)
            {
                Console.Write("Combien de joueurs (entre 4 et 8 joueurs) ? ");
                string nb = Console.ReadLine();
                nb = nb.Replace(" ", "");

                if (string.IsNullOrEmpty(nb))
                {
                    Console.WriteLine("Rentre quelque chose, je vais pas le deviner");
                    nberror++;
                }
                else if (ValidNumber(nb) == true)
                {
                    int targetId = Int32.Parse(nb);
                    return targetId;
                }
                else
                {
                    Console.WriteLine("J'ai dit un NOMBRE entre 4 et 8 ! C'est pas compliqué pourtant ...");
                    nberror++;
                }
            };
        }

        public static int ValidNumberPlayer()
        {
            while (true)
            {
                int n = AskNbPlayer();
                if (n >= 4 && n <= 8)
                {
                    if (nberror > 0)
                    {
                        Console.WriteLine("Et bah voilà ! Tu vois ? C'était pas compliqué !");
                    }
                    return n;
                }
                Console.WriteLine("J'ai dit un NOMBRE entre 4 et 8 ! C'est pas compliqué pourtant ...");
                nberror++;
            }
        }
        

        /// <summary>
        /// Fonction pour créer un joueur et choisir la couleur du pion
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        public Player(string name, string color)
        {          
            _name = name;
            _color = color;
            _character = "None";
            _place = "None";
        }
    }
}
