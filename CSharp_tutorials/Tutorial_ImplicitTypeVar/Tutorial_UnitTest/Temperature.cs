using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Example
{
    class Temperature
    {
        private double _temp;

        public double Temp
        {
            get { return _temp;  }
            set { _temp = value;  }
        }

        public Temperature(double d) 
        {
            Temp = d;
        }
    }
}
