using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    class MechanicFromAsia: CarFactory
    {
        Calculators.ShippingTimeCalculator shipCalc = new  Calculators.ShippingTimeCalculator();
       Calculators.ConstructingTimeCalculator constrCalc = new  Calculators.ConstructingTimeCalculator();

       protected override double GetShippingTime()
       {
            double shippingTimeFromAsia = shipCalc.GetShippingTime(Regions.Asia.distance, Regions.Asia.packingTime, Regions.Asia.packingTimeDeflection, 
                Regions.Asia.shippingSpeed, Regions.Asia.shippingTimeDeflection, Regions.Asia.unpackingTime);

            return shippingTimeFromAsia;
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
