using System;
using System.Collections.Generic;
using System.Text;

namespace shadow_hunter
{
    public class Player
    {
        public string _name { get; set; }
        public string _color { get; set; }
        public string _character { get; set; }
        public string _place { get; set; }

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
