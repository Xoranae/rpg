using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using System;
using System.Collections.Generic;

namespace shadow_hunter
{
    class Program
    {
        public static void Display()
        {
            Console.WriteLine("  _____   _   _       ___   _____   _____   _          __       _   _   _   _   __   _   _____   _____   _____    _____  ");
            Console.WriteLine(" /  ___/ | | | |     /   | |  _  \\ /  _  \\ | |        / /      | | | | | | | | |  \\ | | |_   _| | ____| |  _  \\  /  ___/ ");
            Console.WriteLine(" | |___  | |_| |    / /| | | | | | | | | | | |  __   / /       | |_| | | | | | |   \\| |   | |   | |__   | |_| |  | |___  ");
            Console.WriteLine(" \\___  \\ |  _  |   / / | | | | | | | | | | | | /  | / /        |  _  | | | | | | |\\   |   | |   |  __|  |  _  /  \\___  \\ ");
            Console.WriteLine("  ___| | | | | |  / /  | | | |_| | | |_| | | |/   |/ /         | | | | | |_| | | | \\  |   | |   | |___  | | \\ \\   ___| | ");
            Console.WriteLine(" /_____/ |_| |_| /_/   |_| |_____/ \\_____/ |___/|___/          |_| |_| \\_____/ |_|  \\_|   |_|   |_____| |_|  \\_\\ /_____/ ");
        }
        

        // ------------------------ Jet de dés -------------------------------- //
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
            Random random = new Random();
            return random.Next(1, 4);
        }

        public int JetDes6()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }

        // ------------------------------------------------------------------------------------

            ///
        public static void Characters_generation()
        {
            List<Character> characters = new List<Character>();
            Character.init();

            characters.Add(new Character("Emi", Character.teams[0], 10, "Téléportation", "Pour vous déplacer, vous pouvez lancer normalement les dés, ou vous déplacer sur la carte lieu adjacente."));
            characters.Add(new Character("Georges", Character.teams[0], 14, "Démolition", "Au début de votre tour, choisissez un joueur et infligez-lui autant de Blessures que le résultat d'un dés à 4 faces - Utilisation unique."));
            characters.Add(new Character("Franklin", Character.teams[0], 12, "Foudre", "Au début de votre tour, choisissez un joueur et infligez-lui autant de Blessures que le résultat d'un dés à 6 faces - Utilisation unique."));

            characters.Add(new Character("Loup-Garou", Character.teams[1], 14, "Contre-attaque", "Quand vous êtes attaquez par un joueur, vous pouvez choisir de contre-attaquer juste après que l'attaque initiale a été résolue. Vous pouvez révéler votre identité après avoir été attaqué pour effectuer la contre attaque. Quand vous contre-attaquez, vos équipements ne compte pas."));
            characters.Add(new Character("Vampire", Character.teams[1], 13, "Morsure", "Si vous portez une attaque qui inflige des dommages, soignez immédiatement 2 de vos Blessures."));
            characters.Add(new Character("Métamorphe", Character.teams[1], 11, "Imitation", "Vous pouvez mentir (sans avoir à révélez votre identité) lorsqu'on vous donne une carte Vision."));
            
            characters.Add(new Character("Allie", Character.teams[2], 8, "Amour Maternel", "Soignez toutes vos Blessures - Utilisation unique."));
            characters.Add(new Character("Bob", Character.teams[2], 10, "Braquage", "Si vous infligez au moins 2 Blessures à un autre personnage lors d'une attaque, vous pouvez lui voler une de ses cartes Equipement à la place de lui infliger les Blessures."));
            characters.Add(new Character("Charles", Character.teams[2], 11, "Festin Sanglant", "Après votre attaque, vous pouvez vous infliger 2 Blessures afin d'attaquer de nouveau le même joueur."));
            characters.Add(new Character("Daniel", Character.teams[2], 13, "Désespoir", "Dès qu'un personnage meurt, vous devez révéler votre identité."));

        }

        public static void Worldgeneration()
        {
            List<World> World = new List<World>
            {
                new World("Antre de l'Ermite", 2, 3, "Vous pouvez piocher une carte vision."),
                new World("Porte de l'Outre Monde", 4, 5, "Vous pouvez piocher une carte de la pile de votre choix."),
                new World("Monastère", 6, "Vous pouvez piocher une carte Lumière."),
                new World("Cimetière", 8, "Vous pouvez piocher une carte Ténèbre."),
                new World("Forêt Hantée", 9, "Le joueur de votre choix peut subir 2 Blessures OU soigner 1 Blessure."),
                new World("Sanctuaire Ancien", 10, "Vous pouvez voler une carte équipement à un autre joueur.")
            };
        }



        public static void Main()
        {
            Display();

            Characters_generation();
            Worldgeneration();
        }


        //Console.ReadLine();
    }
}
