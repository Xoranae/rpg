using System;
using System.Collections.Generic;
using System.Text;

namespace shadow_hunter
{
    class character
    {
        /// <summary>
        /// 0 = Hunter ; 1 = Shadow ; 2 = neutre.
        /// </summary>
        public static List<string> teams = new List<string>();

        // Liste des conditions de victoire
        public static List<string> victory_condition = new List<string>();

        public static void init()
        {
            teams.Add("hunter"); // 0
            teams.Add("shadow"); // 1
            teams.Add("neutre"); // 2

            victory_condition.Add("all hunters died or 3 neutres died");    // 0
            victory_condition.Add("all shadow died");                       // 1
        }
        

        public character(string name, string team, int pv, string capacity, string description)
        {
            _name = name;
            _team = team;
            _pv = pv;
            _capacity = capacity;
            _description = description;
            _revealed = false;
            if(team == "shadow")
            {
                _victoryCondition = victory_condition[0];
            }
            else if(team == "hunter")
            {
                _victoryCondition = victory_condition[1];
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
