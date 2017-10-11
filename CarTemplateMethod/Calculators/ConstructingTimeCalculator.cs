using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTemplateMethod.GearBoxTypes;

namespace CarTemplateMethod.Calculators
{
    class ConstructingTimeCalculator
    {
        public double GetConstructingTime(GearBoxType gearBox)
       {
            gearBox.getReadyTime = Deflection.Do(gearBox.getReadyTime, gearBox.getReadyTimeDeflection);
            gearBox.constructingTime = Deflection.Do(gearBox.constructingTime, gearBox.constructingTimeDeflection);
            gearBox.finishingTime = Deflection.Do(gearBox.finishingTime, gearBox.finishingTimeDeflection);
            double constructingTime = gearBox.getReadyTime + gearBox.constructingTime + gearBox.finishingTime;
            PrintConstructingTime(gearBox.getReadyTime, gearBox.constructingTime, gearBox.finishingTime);
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
