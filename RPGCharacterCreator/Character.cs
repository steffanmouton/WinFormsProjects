using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RPGCharacterCreator.UI;

// Singleton Character for app-wide access
namespace RPGCharacterCreator
{
    public sealed class Character
    {
        /// <summary>
        /// Load function, returns a saved character or creates a new one
        /// </summary>
        /// <returns> Character </returns>
        public void Load()
        {
            /*var serializer = new XmlSerializer(typeof(Character));*/
            var fs = FileSelector.Instance;
            
            //creates the save file if it does not already exist and sets it up with default serialization.
            if (!File.Exists(fs.selectedFilePath))
            {
                return;
            }

            Character load = JsonConvert.DeserializeObject<Character>(fs.selectedFileData);
            Name = load.Name;
            CharRace = load.CharRace;
            ClassImplementation = load.ClassImplementation;
            StatBlock = load.StatBlock;
        }

        /// <summary>
        /// Save function. Creates a save file for the character or updates it.
        /// </summary>
        /// <param name="fileName"></param>
        public void Save(Character c, string fileName)
        {
            string output = JsonConvert.SerializeObject(c);
            File.WriteAllText(c.generateFileName(), output);
        }

        public void Clear()
        {
            Name = "";
            CharRace = new Race();
            ClassImplementation = new RPGClass();
            foreach (var e in StatBlock)
            {
                e.Value.StatVal = 10;
            }
        }

        // Variable Instance
        private static Character INSTANCE = new Character();

        // try using ENUM
        public enum STATNAME { STR = 0, DEX = 1, CON = 2, INT = 3, WIS = 4, CHA = 5 }
        public IDictionary<string, Stat> StatBlock = new Dictionary<string, Stat>();

        //constructor
        private Character()
        {
            foreach (var e in Enum.GetValues(typeof(STATNAME)))
            {
                StatBlock.Add(e.ToString(), new Stat());
            }

            Name = "";
            CharRace = new Race();
            ClassImplementation = new RPGClass();

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

        public IClass ClassImplementation { get; set; }
        
        public string generateFileName()
        {
            string tempName = Name;

            string saveFileName = tempName += ".json";

            return saveFileName;
        }
    }
}
