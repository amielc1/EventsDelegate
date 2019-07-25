using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegate.SmokeSubscribes
{
    public class Ambulance
    {
        SmokeDetector smokeDetector;
        public Ambulance(SmokeDetector smokeDetector)
        {
            this.smokeDetector = smokeDetector;
            smokeDetector.evSmokeDetected += SmokeDetector_evSmokeDetected;
            //this delegate registration delete all previos subscibers 
            smokeDetector.delSmokeDetected = SmokeDetector_delSmokeDetected;
        }

        private void SmokeDetector_evSmokeDetected(double smokeRate)
        {
            Console.WriteLine($"Event Smoke detected! {smokeRate} {this}");
        }
        private void SmokeDetector_delSmokeDetected(double smokeRate)
        {
            Console.WriteLine($"Delegate Smoke detected! {smokeRate} {this}");
        }

        public void RaiseAll()
        {
            //smokeDetector.evSmokeDetected(4); It is not possible to fire event outside its class!!
            smokeDetector.delSmokeDetected(3);//It is possible to invoke delegate outside its class!!
        }
    }

}
