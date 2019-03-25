using System.Collections.Generic;

namespace RPGCharacterCreator
{
    class SourceData
    {
        /// <summary>
        /// List of races that can be assigned to Character
        /// </summary>
        public static List<Race> races = new List<Race>
        {
            new Race {Name = "Human"},
            new Race {Name = "Dwarf"},
            new Race {Name = "Elf"},
            new Race {Name = "Halfling"},
            new Race {Name = "Orc"},
            new Race {Name = "Dragonborn"},
            new Race {Name = "Gnome"},
            new Race {Name = "Tiefling"}
        };

        /// <summary>
        /// List of Classes that can be assigned to Character
        /// by their IClass interface
        /// </summary>
        public static List<IClass> classes = new List<IClass>
        {
            new RPGClass {Name = "Barbarian", RecStats = "STR & CON"},
            new RPGClass {Name = "Bard", RecStats = "CHA & DEX(fast)/STR(strong)"},
            new RPGClass {Name = "Cleric", RecStats = "WIS & STR(tough)/DEX(quick)"},
            new RPGClass {Name = "Druid", RecStats = "WIS & CON"},
            new RPGClass {Name = "Fighter", RecStats = "STR(beefy warrior)/DEX(fast warrior) & CON"},
            new RPGClass {Name = "Monk",RecStats = "DEX & WIS"},
            new RPGClass {Name = "Paladin", RecStats = "STR & CHA"},
            new RPGClass {Name = "Ranger", RecStats = "DEX & WIS"},
            new RPGClass {Name = "Rogue", RecStats = "DEX & CHA"},
            new RPGClass {Name = "Sorcerer", RecStats = "CHA & CON"},
            new RPGClass {Name = "Warlock", RecStats = "CHA & CON"},
            new RPGClass {Name = "Wizard", RecStats = "INT & CON"}
        };
    }
}
