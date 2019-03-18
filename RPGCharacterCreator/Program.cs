using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;
using RPGCharacterCreator.UI;

namespace RPGCharacterCreator
{
    static class Program
    {
        /// <summary>
        /// Load function, returns a saved character or creates a new one
        /// </summary>
        /// <param name="c"></param>
        /// <param name="fileName"></param>
        /// <returns> Character </returns>
        public static Character Load(Character c, string fileName)
        {
            /*var serializer = new XmlSerializer(typeof(Character));*/
            var fs = FileSelector.Instance;
            //creates the save file if it does not already exist and sets it up with default serialization.
            if (!File.Exists(fileName))
            {
                return c;
            }

            //opens up current savefile as the stream to deserialize
            string input = File.ReadAllText(fileName);

            //assigns the referenced clicker with the deserialized stream
            c = JsonConvert.DeserializeObject<Character>(fs.selectedFileData);

            return c;
        }

        /// <summary>
        /// Save function. Creates a save file for the character or updates it.
        /// </summary>
        /// <param name="clicker"></param>
        /// <param name="fileName"></param>
        public static void Save(Character c, string fileName)
        {
            /*var serializer = new XmlSerializer(typeof(Character));
            var sw = new StreamWriter(fileName);
            serializer.Serialize(sw, clicker);
            sw.Close();*/
            
            string output = JsonConvert.SerializeObject(c);
            File.WriteAllText(c.generateFileName(), output);

        }

        public static List<Race> races = new List<Race>
        {
            new Race {Name = "Dwarf"}, new Race {Name = "Human"}, new Race {Name = "Elf"}
        };

        /// <summary>
        /// Creates a list of Classes by their IClass interface 
        /// </summary>
        public static List<IClass> classes = new List<IClass>
        {
            new RPGClass {Name = "Barbarian", RecStats = "STR"}, new RPGClass {Name = "Bard", RecStats = "CHA"},
            new RPGClass {Name = "Cleric", RecStats = "WIS"}, new RPGClass {Name = "Druid", },
            new RPGClass {Name = "Fighter"}, new RPGClass {Name = "Monk"}, new RPGClass {Name = "Paladin"},
            new RPGClass {Name = "Ranger"},
            new RPGClass {Name = "Rogue"}, new RPGClass {Name = "Sorcerer"}, new RPGClass {Name = "Warlock"},
            new RPGClass {Name = "Wizard"}
        };

        public static string fileName = "Character.txt";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var c = Character.Instance;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartupForm());
        }
    }
}
