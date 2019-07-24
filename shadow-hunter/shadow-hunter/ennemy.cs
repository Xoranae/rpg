using System;
using System.Collections.Generic;
using System.Text;

namespace shadowhunter
{
    public class ennemy
    {
        public ennemy(string name, int level, int life)
        {
            this._name = name;
            this._level = level;
            this._life = life;
        }

        public string _name { get; set; }
        public int _level { get; set; }
        public int _life { get; set; }
        
    }
}
