using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator
{
    class Stat
    {
        private int _statistic;

        public int StatVal
        {
            get { return _statistic; }
            set { _statistic = value; }
        }

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
