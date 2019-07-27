using EventsDelegate.SmokeSubscribes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SmokeDetector smokeDetector = new SmokeDetector();
                FiremanSam firemanSam = new FiremanSam(smokeDetector);
                Ambulance ambulance = new Ambulance(smokeDetector);

                ambulance.RaiseAll();

                smokeDetector.SmokeRate = 10;
                smokeDetector.SmokeRate = 30;

                smokeDetector.evSmokeDetected += SmokeDetector_evSmokeDetected;
                smokeDetector.evSmokeDetected += SmokeDetector_evSmokeDetectedExeption;
                smokeDetector.evSmokeDetected += SmokeDetector_evSmokeDetectedGood;
                smokeDetector.SafeRaise();
            }
            catch (Exception)
            {
            }
            Console.ReadLine();
        }

        private static void SmokeDetector_evSmokeDetected(object sender, SmokeDetectorArgs e)
        {
            Console.WriteLine($"1SmokeDetector_evSmokeDetected Smoke detected! {e.ToString()} {sender}");
        }
        private static void SmokeDetector_evSmokeDetectedExeption(object sender, SmokeDetectorArgs e)
        {
            throw new NotImplementedException("2SafeEvent");
        }
        private static void SmokeDetector_evSmokeDetectedGood(object sender, SmokeDetectorArgs e)
        {
            Console.WriteLine($"3SmokeDetector_evSmokeDetectedGood Smoke detected! {e.ToString()} {sender}");
        }
    }
}
