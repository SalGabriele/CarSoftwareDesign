using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTemplateMethod.GearBoxTypes;
using CarTemplateMethod.Regions;
using CarTemplateMethod.Calculators;

namespace CarTemplateMethod
{
    class AutomaticFromEurope: CarFactory
    {
        ShippingTimeCalculator shipCalc = new ShippingTimeCalculator();
        ConstructingTimeCalculator constrCalc = new ConstructingTimeCalculator();
        Europe europe = new Europe();
        AutomaticGearBox auto = new AutomaticGearBox();

       protected override double GetShippingTime()
       {
            double shippingTimeFromEurope = shipCalc.GetShippingTime(europe);

            return shippingTimeFromEurope;
       }

        protected override double GetConstructingTime()
       {
            double constructingTimeA = constrCalc.GetConstructingTime(auto);
            
            return constructingTimeA;
       }
    }
}
