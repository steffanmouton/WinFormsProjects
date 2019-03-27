namespace RPGCharacterCreator
{
    public class Stat
    {
        /// <summary>
        ///     Default constructor of a Statistic value.
        ///     Currently set to 10 for DnD 5e standards.
        /// </summary>
        public Stat()
        {
            StatVal = 10;
        }

        public int StatVal { get; set; }

        /// <summary>
        ///     Property that returns the modifier value of the _statistic value
        ///     Uses DnD 5e formula.
        /// </summary>
        public int Mod
        {
            get
            {
                if (StatVal >= 0)
                    return (StatVal - 10) / 2;

                return (StatVal - 11) / 2;
            }
        }
    }
}