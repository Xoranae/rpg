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


        public static void init()
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
    }
}
