﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator
{
    public sealed class Character
    {
        //Variable Instance
        private static Character INSTANCE = new Character();

        // try using ENUM
        public enum STATNAME { STR = 0, DEX = 1, CON = 2, INT = 3, WIS = 4, CHA = 5 }
        IDictionary<string, Stat> StatBlock = new Dictionary<string, Stat>();

        //constructor
        private Character()
        {
            foreach (var e in Enum.GetValues(typeof(STATNAME)))
            {
                StatBlock.Add(e.ToString(), new Stat());
            }

            Name = "";
            CharRace = new Race();
            CharClass = new RPGClass();

        }

        //Property
        public static Character Instance
        {
            get
            {
                if (INSTANCE == null)
                {
                    INSTANCE = new Character();
                }
                return INSTANCE;
            }
        }

        public string Name { get; set; }
        public Race CharRace { get; set; }
        public RPGClass CharClass { get; set; }

    }
}
