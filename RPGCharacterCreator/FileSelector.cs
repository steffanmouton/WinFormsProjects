using System;

namespace RPGCharacterCreator.UI
{
    /// <summary>
    /// File Selector singleton. Keeps track of file path data as needed.
    /// </summary>
    public sealed class FileSelector
    {
        private static FileSelector INSTANCE = new FileSelector();

        public string defaultFilePath { get; set; }
        public string selectedFilePath { get; set; }
        public string selectedFileData { get; set; }

        private FileSelector()
        {
            defaultFilePath = Environment.CurrentDirectory;
        }

        public static FileSelector Instance
        {
            get
            {
                if (INSTANCE == null)
                {
                    INSTANCE = new FileSelector();
                }

                return INSTANCE;
            }
        }
    }
}
