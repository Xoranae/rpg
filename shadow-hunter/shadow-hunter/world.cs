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
    }
}
