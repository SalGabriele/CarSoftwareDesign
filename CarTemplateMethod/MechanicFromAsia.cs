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
    class MechanicFromAsia: CarFactory
    {
        ShippingTimeCalculator shipCalc = new ShippingTimeCalculator();
        ConstructingTimeCalculator constrCalc = new ConstructingTimeCalculator();
        Asia asia = new Asia();
        MechanicGearBox mech = new MechanicGearBox();

       protected override double GetShippingTime()
       {
            double shippingTimeFromAsia = shipCalc.GetShippingTime(asia);

            return shippingTimeFromAsia;
       }

        protected override double GetConstructingTime()
       {
            double constructingTimeM = constrCalc.GetConstructingTime(mech);
            
            return constructingTimeM;
       }
    }
}
