using System;
using System.Collections.Generic;
using System.Text;

namespace shadow_hunter
{
    class item
    {
        public string name { get; set; }
        public string type { get; set; } //object or weapon
        public int power { get; set; } //attack or protection power
        public string description { get; set; }

        /// <summary>
        /// create a item object with given parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="power"></param>
        /// <param name="description"></param>
        public item(string name, string type, int power, string description)
        {
            this.name = name;
            this.type = type;
            this.power = power;
            this.description = description;
        }
        
        /// <summary>
        /// create a item object with given parameters and default power of 10
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="power"></param>
        public item(string name, string type, string description)
        {
            this.name = name;
            this.type = type;
            this.power = 10;
            this.description = description;
        }
    }
}
