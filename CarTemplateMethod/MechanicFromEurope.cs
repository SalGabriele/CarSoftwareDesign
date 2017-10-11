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
    class MechanicFromEurope: CarFactory
    {
        ShippingTimeCalculator shipCalc = new ShippingTimeCalculator();
        ConstructingTimeCalculator constrCalc = new ConstructingTimeCalculator();
        Europe europe = new Europe();
        MechanicGearBox mech = new MechanicGearBox();

       protected override double GetShippingTime()
       {
            double shippingTimeFromEurope = shipCalc.GetShippingTime(europe);

            return shippingTimeFromEurope;
       }

        protected override double GetConstructingTime()
       {
            double constructingTimeM = constrCalc.GetConstructingTime(mech);
            
            return constructingTimeM;
       }
    }
}
