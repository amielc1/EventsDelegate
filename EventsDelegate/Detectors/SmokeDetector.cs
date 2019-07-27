using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegate
{
    public class SmokeDetectorArgs : EventArgs
    {
        public double SmokeRate { get; set; }
        public string SokeLocation { get; set; }
        public SmokeDetectorArgs(double smokeRate, string sokeLocation)
        {
            SmokeRate = smokeRate;
            SokeLocation = sokeLocation;
        }
        public override string ToString()
        {
            return $"Smoke Rate {SmokeRate} , Location {SokeLocation}";
        }
    }
    public class SmokeDetector
    {
        public Action<double> delSmokeDetected;
        private event EventHandler<SmokeDetectorArgs> _evSmokeDetected = delegate { };
        public event EventHandler<SmokeDetectorArgs> evSmokeDetected
        {
            add
            {
                lock (_evSmokeDetected)
                {
                    _evSmokeDetected += value;
                }
            }
            remove
            {
                lock (_evSmokeDetected)
                {
                    _evSmokeDetected -= value;

                }
            }
        }
        private double _SmokeRate;
        public double SmokeRate
        {
            get { return _SmokeRate; }
            set
            {
                _SmokeRate = value;
                if (_SmokeRate > 20)
                {
                    _evSmokeDetected(this, new SmokeDetectorArgs(value, "Bulding 1"));
                    delSmokeDetected(value);
                }
            }
        }
    }

}
