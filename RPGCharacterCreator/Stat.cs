using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator
{
    public class Stat
    {
        private int _statistic;

        /// <summary>
        /// Default constructor of a Statistic value.
        /// Currently set to 10 for DnD 5e standards.
        /// </summary>
        public Stat()
        {
            _statistic = 10;
        }
        public int StatVal
        {
            get { return _statistic; }
            set
            {
                _statistic = value;

                //TODO : Add delegates
                //StatBlockSelector.EventStatChanged.Invoke(this);

            }
        }

        /// <summary>
        /// Property that returns the modifier value of the _statistic value
        /// Uses DnD 5e formula.
        /// </summary>
        public int Mod
        {
            get
            {
                if (_statistic >= 0)
                    return (_statistic - 10) / 2;

                else
                    return (_statistic - 11) / 2;
            }
        }
    }
}
