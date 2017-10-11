using System;
using CarTemplateMethod.GearBoxTypes;

namespace CarTemplateMethod.Calculators
{
    class ConstructingTimeCalculator
    {
        public double GetConstructingTime(GearBoxType gearBox)
       {
            gearBox.GetReadyTime = Deflection.Do(gearBox.GetReadyTime, gearBox.GetReadyTimeDeflection);
            gearBox.ConstructingTime = Deflection.Do(gearBox.ConstructingTime, gearBox.ConstructingTimeDeflection);
            gearBox.FinishingTime = Deflection.Do(gearBox.FinishingTime, gearBox.FinishingTimeDeflection);
            double constructingTime = gearBox.GetReadyTime + gearBox.ConstructingTime + gearBox.FinishingTime;
            PrintConstructingTime(gearBox.GetReadyTime, gearBox.ConstructingTime, gearBox.FinishingTime);
            return constructingTime;
       }

       private void PrintConstructingTime(double ready, double constructing, double finishing)
        {
            Console.WriteLine("Getting ready takes " + ready + " hours");
            Console.WriteLine("Constructing Gear Box takes " + constructing + " hours");
            Console.WriteLine("Putting Gear Box to the car takes " + finishing + " hours");
        }
    }
}
