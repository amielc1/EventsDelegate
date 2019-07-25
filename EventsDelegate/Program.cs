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
            }
            catch (Exception)
            {
            }
            Console.ReadLine();
        }
    }
}
