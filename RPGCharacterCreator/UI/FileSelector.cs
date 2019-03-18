using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.UI
{
    public sealed class FileSelector
    {
        private static FileSelector INSTANCE = new FileSelector();

        public string defaultFilePath { get; set; }
        public string selectedFilePath { get; set; }
        public string selectedFileData { get; set; }

        private FileSelector()
        {
            defaultFilePath = @"C: \Users\s188045\Documents\GitHub\
            WinFormsProjects\RPGCharacterCreator\bin\Debug";
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
