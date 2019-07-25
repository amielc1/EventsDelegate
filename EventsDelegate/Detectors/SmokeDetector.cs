using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegate
{
    public class SmokeDetector
    {
        public Action<double> delSmokeDetected;
        public event Action<double> evSmokeDetected;

        private double _SmokeRate;
        public double SmokeRate
        {
            get { return _SmokeRate; }
            set
            {
                _SmokeRate = value;
                if (_SmokeRate > 20)
                {
                    evSmokeDetected(value);
                    delSmokeDetected(value);
                }
            }
        }
    }

}
