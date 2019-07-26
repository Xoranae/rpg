using System;
using System.Collections.Generic;
using System.Text;

namespace shadow_hunter
{
    class Character
    {
        /// <summary>
        /// 0 = Hunter ; 1 = Shadow ; 2 = neutre.
        /// </summary>
        public static List<string> teams = new List<string>();

        // Liste des conditions de victoire
        /// <summary>
        /// 0. Condition de victoire des Shadows - 1. Condition de victoire des Hunters - 2. Condition de victoire d'Allie - 3. Condition de victoire de Bob - 4. Condition de Victoire de Charles - 5. Condition de Victoire de Daniel
        /// </summary>
        public static List<string> victory_condition = new List<string>();


        public static void Init()
        {
            teams.Add("hunter"); // 0
            teams.Add("shadow"); // 1
            teams.Add("neutre"); // 2

            victory_condition.Add("Tous les Hunters sont morts ou 3 personnages neutres sont morts");                               // 0
            victory_condition.Add("Tous les Shadow sont morts");                                                                    // 1
            victory_condition.Add("Être encore en vie lorsque la partie se termine");                                               // 2
            victory_condition.Add("Posséder 5 cartes équipement ou plus");                                                          // 3
            victory_condition.Add("Tuer un autre personnage par une attaque alors qu'il y a déjà eu 3 morts ou plus");              // 4
            victory_condition.Add("Être le premier joueur à mourir OU être en vie quand tous les personnages Shadow sont morts.");  // 5 
        }
        

        public Character(string name, string team, int pv, string capacity, string description)
        {
            _name = name;
            _team = team;
            _pv = pv;
            _capacity = capacity;
            _description = description;
            _revealed = false;
            switch (team)
            {
                case "Shadow":
                    _victoryCondition = victory_condition[0];
                    break;
                case "Hunter":
                    _victoryCondition = victory_condition[1];
                    break;
                default:
                    switch (name)
                    {
                        case "Allie":
                            _victoryCondition = victory_condition[2];
                            break;
                        case "Bob":
                            _victoryCondition = victory_condition[3];
                            break;
                        case "Charles":
                            _victoryCondition = victory_condition[4];
                            break;
                        case "Daniel":
                            _victoryCondition = victory_condition[5];
                            break;
                    }
                    break;
            }

        }

        public string _name { get; set; }
        public string _team { get; set; }
        public int _pv { get; set; }
        public string _capacity { get; set; }
        public string _description { get; set; }
        public bool _revealed { get; set; }
        public string _victoryCondition { get; set; }

        public static void Characters_generation(int nbplayer) // Génération des personnages
        {
            Character.Init();

            HunterCharacters = new List<Character>()
            {
                new Character("Emi", Character.teams[0], 10, "Téléportation", "Pour vous déplacer, vous pouvez lancer normalement les dés, ou vous déplacer sur la carte lieu adjacente."),
                new Character("Georges", Character.teams[0], 14, "Démolition", "Au début de votre tour, choisissez un joueur et infligez-lui autant de Blessures que le résultat d'un dés à 4 faces - Utilisation unique."),
                new Character("Franklin", Character.teams[0], 12, "Foudre", "Au début de votre tour, choisissez un joueur et infligez-lui autant de Blessures que le résultat d'un dés à 6 faces - Utilisation unique.")
            };

            ShadowCharacters = new List<Character>()
            {
                new Character("Loup-Garou", Character.teams[1], 14, "Contre-attaque", "Quand vous êtes attaquez par un joueur, vous pouvez choisir de contre-attaquer juste après que l'attaque initiale a été résolue. Vous pouvez révéler votre identité après avoir été attaqué pour effectuer la contre attaque. Quand vous contre-attaquez, vos équipements ne compte pas."),
                new Character("Vampire", Character.teams[1], 13, "Morsure", "Si vous portez une attaque qui inflige des dommages, soignez immédiatement 2 de vos Blessures."),
                new Character("Métamorphe", Character.teams[1], 11, "Imitation", "Vous pouvez mentir (sans avoir à révélez votre identité) lorsqu'on vous donne une carte Vision.")

            };

            NeutreCharacters = new List<Character>()
            {
                new Character("Allie", Character.teams[2], 8, "Amour Maternel", "Soignez toutes vos Blessures - Utilisation unique."),
                new Character("Bob", Character.teams[2], 10, "Braquage", "Si vous infligez au moins 2 Blessures à un autre personnage lors d'une attaque, vous pouvez lui voler une de ses cartes Equipement à la place de lui infliger les Blessures."),
                new Character("Daniel", Character.teams[2], 13, "Désespoir", "Dès qu'un personnage meurt, vous devez révéler votre identité.")
            };

            // 6 joueurs ou plus pour l'apparition
            if (nbplayer >= 6)
            {
                NeutreCharacters.Add(new Character("Charles", Character.teams[2], 11, "Festin Sanglant", "Après votre attaque, vous pouvez vous infliger 2 Blessures afin d'attaquer de nouveau le même joueur."));
            }

        }

        public static List<Character> HunterCharacters { get; set; }
        public static List<Character> ShadowCharacters { get; set; }
        public static List<Character> NeutreCharacters { get; set; }

        
    }
}

