using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod.Calculators
{
    class ConstructingTimeCalculator
    {
        public double GetConstructingTime(double ready, int readyD, double construct, int constructD, double finish, int finishD)
       {
            ready = Deflection.Do(ready, readyD);
            construct = Deflection.Do(construct, constructD);
            finish = Deflection.Do(finish, finishD);
            double constructingTime = ready + construct + finish;
            PrintConstructingTime(ready, construct, finish);
            return constructingTime;
       }

       private void PrintConstructingTime(double ready, double constructing, double finishing)
        {
            Console.WriteLine("Getting ready takes " + ready + "hours");
            Console.WriteLine("Constructing Gear Box takes " + constructing + " hours");
            Console.WriteLine("Putting Gear Box to the car takes " + finishing + " hours");
        }
    }
}
