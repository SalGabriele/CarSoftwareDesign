using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    class MechanicFromEurope: CarFactory
    {
        Calculators.ShippingTimeCalculator shipCalc = new  Calculators.ShippingTimeCalculator();
        Calculators.ConstructingTimeCalculator constrCalc = new  Calculators.ConstructingTimeCalculator();

       protected override double GetShippingTime()
       {
            double shippingTimeFromEurope = shipCalc.GetShippingTime(Regions.Europe.distance, Regions.Europe.packingTime, Regions.Europe.packingTimeDeflection, 
                Regions.Europe.shippingSpeed, Regions.Europe.shippingTimeDeflection, Regions.Europe.unpackingTime);

            return shippingTimeFromEurope;
       }

        protected override double GetConstructingTime()
       {
            double constructingTimeM = constrCalc.GetConstructingTime(GearBoxTypes.MechanicGearBox.getReadyTime, 
                GearBoxTypes.MechanicGearBox.getReadyTimeDeflection, GearBoxTypes.MechanicGearBox.constructingTime, 
                GearBoxTypes.MechanicGearBox.constructingTimeDeflection, GearBoxTypes.MechanicGearBox.finishingTime, 
                GearBoxTypes.MechanicGearBox.finishingTimeDeflection);
            
            return constructingTimeM;
       }
    }
}
