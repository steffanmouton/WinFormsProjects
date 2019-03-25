
namespace RPGCharacterCreator
{
    /// <summary>
    /// Interface that ensures a class has a name and can be referenced by the interface
    /// </summary>
    public interface IClass
    {
        string Name { get; set; }
    }

    /// <inheritdoc />
    /// <summary>
    /// RPG Class. Inherits from IClass. Contains a nameImplementation, Name string Property
    /// and a Recommended stats string
    /// </summary>
    public class RPGClass : IClass
    {
        /// <summary>
        /// Instance of IClass for nameImplementation
        /// </summary>
        private IClass _nameImplementation = new ClassNameGenerator();

        /// <summary>
        /// Name string property
        /// </summary>
        public string Name
        {
            get => _nameImplementation.Name;
            set => _nameImplementation.Name = value;
        }

        /// <summary>
        /// String detailing recommended statistics for the chosen Class
        /// </summary>
        public string RecStats { get; set; }
    }
    
    /// <inheritdoc />
    /// <summary>
    /// Class that contains Name string, for use in Interface implementation inside
    /// RPGClass
    /// </summary>
    public class ClassNameGenerator : IClass
    {
        public string Name { get; set; }
    }
}
