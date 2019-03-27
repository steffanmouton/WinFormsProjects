using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RPGCharacterCreator.UI;

// Singleton Character for app-wide access
namespace RPGCharacterCreator
{
    public delegate void OnCharacterNameChanged(Character c);

    public sealed class Character
    {
        // try using ENUM
        public enum STATNAME
        {
            STR = 0,
            DEX = 1,
            CON = 2,
            INT = 3,
            WIS = 4,
            CHA = 5
        }

        // Variable Instance
        private static Character INSTANCE = new Character();
        private Race _charRace;
        private IClass _classImplementation;

        private string _cname;

        [NonSerialized] public OnCharacterNameChanged onCharacterChanged;

        //law of demeter respect: dont use the guy to talk to the other guy
        public IDictionary<string, Stat> StatBlock = new Dictionary<string, Stat>();

        //constructor
        private Character()
        {
            foreach (var e in Enum.GetValues(typeof(STATNAME))) StatBlock.Add(e.ToString(), new Stat());

            Name = null;
            CharRace = new Race();
            ClassImplementation = new RPGClass();
        }

        //Property
        public static Character Instance
        {
            get
            {
                if (INSTANCE == null) INSTANCE = new Character();

                return INSTANCE;
            }
        }

        public string Name
        {
            get => _cname;
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
        ///     Load function, returns a saved character or creates a new one
        /// </summary>
        /// <returns> Character </returns>
        public void Load()
        {
            /*var serializer = new XmlSerializer(typeof(Character));*/
            var fs = FileSelector.Instance;

            //creates the save file if it does not already exist and sets it up with default serialization.
            if (!File.Exists(fs.selectedFilePath)) return;

            var load = JsonConvert.DeserializeObject<Character>(fs.selectedFileData);
            Name = load.Name;
            CharRace = load.CharRace;
            ClassImplementation = load.ClassImplementation;
            StatBlock = load.StatBlock;
        }

        /// <summary>
        ///     Save function. Creates a save file for the character or updates it.
        /// </summary>
        public void Save()
        {
            var output = JsonConvert.SerializeObject(this);
            File.WriteAllText(generateFileName(), output);
        }

        public void Clear()
        {
            Name = null;
            CharRace = new Race();
            ClassImplementation = new RPGClass();
            foreach (var e in StatBlock) e.Value.StatVal = 10;
        }

        public string generateFileName()
        {
            var tempName = Name;

            var saveFileName = string.Format("SavedCharacters/{0}.json", tempName);

            return saveFileName;
        }

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