using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegate.SmokeSubscribes
{
    public class FiremanSam
    {
        SmokeDetector smokeDetector;
        public FiremanSam(SmokeDetector smokeDetector)
        {
            this.smokeDetector = smokeDetector;
            smokeDetector.evSmokeDetected += SmokeDetector_evSmokeDetected;
            smokeDetector.delSmokeDetected += SmokeDetector_delSmokeDetected;
        }

        private void SmokeDetector_evSmokeDetected(double smokeRate)
        {
            Console.WriteLine($"Event Smoke detected! {smokeRate} {this}" );
        }
        private void SmokeDetector_delSmokeDetected(double smokeRate)
        {
            Console.WriteLine($"Delegate Smoke detected! {smokeRate} {this}");
        }
    }
}
