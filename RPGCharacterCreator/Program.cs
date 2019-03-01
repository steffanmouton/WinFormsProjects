﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RPGCharacterCreator
{
    static class Program
    {
        public static Character Load(Character c, string fileName)
        {

            var serializer = new XmlSerializer(typeof(Character));


            //creates the save file if it does not already exist and sets it up with default serialization.
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();

                var sw = new StreamWriter(fileName);
                serializer.Serialize(sw, c);
                sw.Close();
            }

            //opens up current savefile as the stream to deserialize
            Stream stream = File.Open(fileName, FileMode.Open);

            //assigns the referenced clicker with the deserialized stream
            c = (Character)serializer.Deserialize(stream);
            stream.Close();

            return c;
        }

        public static void Save(Character clicker, string fileName)
        {

            var serializer = new XmlSerializer(typeof(Character));
            var sw = new StreamWriter(fileName);
            serializer.Serialize(sw, clicker);
            sw.Close();
        }

        public static List<Race> races = new List<Race>
        {
            new Race {Name = "Dwarf"}, new Race {Name = "Human"}, new Race {Name = "Elf"}
        };

        //Creates a list of classes by their IName interface
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
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartupForm());
            
        }
    }
}
