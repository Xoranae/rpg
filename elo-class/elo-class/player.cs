using System;
using System.Collections.Generic;
using System.Text;

namespace elo_class
{
    public class player
    {
        public string _name { get; set; }
        public int _level { get; set; }
        public int _life { get; set; }

        /// <summary>
        /// create a Player object with given level
        /// </summary>
        /// <param name="name"></param>
        /// <param name="level"></param>
        public player(string name, int level, int life)
        {
            verifyParameter(name);
            this._name = name;
            this._level = level;
            this._life = life;
        }

        /// <summary>
        /// create a Player object with default level 1
        /// </summary>
        /// <param name="name"></param>
        public player(string name)
        {
            verifyParameter(name);
            this._name = name;
            _level = 1;
            _life = 10;
        }

        /// <summary>
        /// verify if a parameter of type string
        /// </summary>
        /// <param name="name"></param>
        void verifyParameter(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("name can not be null", name);
            }
        }
    }
}
