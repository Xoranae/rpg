using System;
using System.Collections.Generic;
using System.Text;

namespace shadow_hunter
{
    class World
    {
        public string _name { get; set; }
        public int _value1 { get; set; }
        public int _value2 { get; set; }
        public string _description { get; set; }

        public World(string name, int value1, int value2, string description)
        {
            _name = name;
            _value1 = value1;
            _value2 = value2;
            _description = description;
        }

        public World(string name, int value1, string description)
        {
            _name = name;
            _value1 = value1;
            _value2 = 0;
            _description = description;
        }
        public static List<World> Worlds { get; set; }

        public static void Worldgeneration()
        {
            Worlds = new List<World>
            {
                new World("Antre de l'Ermite", 2, 3, "Vous pouvez piocher une carte vision."),
                new World("Porte de l'Outre Monde", 4, 5, "Vous pouvez piocher une carte de la pile de votre choix."),
                new World("Monastère", 6, "Vous pouvez piocher une carte Lumière."),
                new World("Cimetière", 8, "Vous pouvez piocher une carte Ténèbre."),
                new World("Forêt Hantée", 9, "Le joueur de votre choix peut subir 2 Blessures OU soigner 1 Blessure."),
                new World("Sanctuaire Ancien", 10, "Vous pouvez voler une carte équipement à un autre joueur.")
            };
        }

    }
}
