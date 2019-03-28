using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RPGCharacterCreator.UI;

// Singleton Character for app-wide access
namespace RPGCharacterCreator
{
    /// <summary>
    /// Delegate that is invoked in response to the Character being changed.
    /// </summary>
    /// <param name="c"></param>
    public delegate void OnCharacterNameChanged(Character c);
    
    /// <summary>
    /// Singleton class containing the data relevant to the Character
    /// </summary>
    public sealed class Character
    {
        [NonSerialized]
        public OnCharacterNameChanged onCharacterChanged;

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
        public void Save()
        {
            string output = JsonConvert.SerializeObject(this);
            File.WriteAllText(this.generateFileName(), output);
        }

        /// <summary>
        /// Resets Character to default values, creating a "New" one.
        /// </summary>
        public void Clear()
        {
            Name = "___";
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
        
        //law of demeter respect: dont use the guy to talk to the other guy
        public IDictionary<string, Stat> StatBlock = new Dictionary<string, Stat>();

        //constructor
        private Character()
        {
            foreach (var e in Enum.GetValues(typeof(STATNAME)))
            {
                StatBlock.Add(e.ToString(), new Stat());
            }

            Name = null;
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

        private string _cname;
        private Race _charRace;
        private IClass _classImplementation;

        public string Name
        {
            get { return _cname; }
            set
            {
                _cname = value;
                onCharacterChanged?.Invoke(this);
            }
        }

        public Race CharRace
        {
            get => _charRace;
            set
            {
                _charRace = value;
                onCharacterChanged?.Invoke(this);
            }
        }

        public IClass ClassImplementation
        {
            get => _classImplementation;
            set
            {
                _classImplementation = value;
                onCharacterChanged?.Invoke(this);
            }
        }

        /// <summary>
        /// Returns a string built for use in saving
        /// </summary>
        /// <returns></returns>
        public string generateFileName()
        {
            string tempName = Name;

            string saveFileName = tempName += ".json";

            return saveFileName;
        }

        /// <summary>
        /// Returns the full title of the character for display
        /// </summary>
        /// <returns></returns>
        public string ReturnTitle()
        {
            string _cName = "___", _cRace = "___", _cClass = "___";

            if (Name != null)
                _cName = Name;
            if (CharRace.Name != null)
                _cRace = CharRace.Name;
            if (ClassImplementation.Name != null)
                _cClass = ClassImplementation.Name;

            var charFullTitle = string.Format("{0}, the {1} {2}", _cName, _cRace, _cClass);
            return charFullTitle;
        }
    }
}
