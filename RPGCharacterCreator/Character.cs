using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question:1 HOW DO I GET CODE TO SHOW UP as useful application data
//Example: define a range of enum or type to be selected by user then use that
//selection to modfiy program behaviour
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

        // try using ENUM

        public enum STATNAME { STR = 0, DEX = 1, CON = 2, INT = 3, WIS = 4, CHA = 5 }

    }
}
