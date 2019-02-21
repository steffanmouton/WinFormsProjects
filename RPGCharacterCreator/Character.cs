using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator
{
    class Character
    {
        public string Name { get; set; }
        public Race CharRace { get; set; }
        public RPGClass CharClass { get; set; }

        IDictionary<string, Stat> StatBlock = new Dictionary<string, Stat>();
        public Character()
        {
            foreach (var e in Enum.GetValues(typeof(STATNAME)))
            {
                StatBlock.Add(e.ToString(), new Stat());
            }
        }

        //try using ENUM

        public enum STATNAME { STR = 0, DEX = 1, CON = 2, INT = 3, WIS = 4, CHA = 5 }
    }
}
