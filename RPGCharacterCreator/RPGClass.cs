using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator
{
    public interface IClass
    {
        string Name { get; set; }
    }
    public class RPGClass : IClass
    {
        private IClass _nameImplementation = new ClassNameGenerator();

        public string Name
        {
            get => _nameImplementation.Name;
            set => _nameImplementation.Name = value;
        }

        public string RecStats { get; set; }
    }
    
    public class ClassNameGenerator : IClass
    {
        public string Name { get; set; }
    }
}
