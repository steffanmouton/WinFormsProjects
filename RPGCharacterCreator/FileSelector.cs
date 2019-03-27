using System;

namespace RPGCharacterCreator.UI
{
    public sealed class FileSelector
    {
        private static FileSelector INSTANCE = new FileSelector();

        private FileSelector()
        {
            defaultFilePath = string.Format("{0}\\SavedCharacters", Environment.CurrentDirectory);
        }

        public string defaultFilePath { get; set; }
        public string selectedFilePath { get; set; }
        public string selectedFileData { get; set; }

        public static FileSelector Instance
        {
            get
            {
                if (INSTANCE == null) INSTANCE = new FileSelector();

                return INSTANCE;
            }
        }
    }
}