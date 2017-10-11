using CarTemplateMethod.GearBoxTypes;
using CarTemplateMethod.Regions;
using CarTemplateMethod.Calculators;

namespace CarTemplateMethod
{
    class AutomaticFromAsia: CarFactory
    {
        ShippingTimeCalculator shipCalc = new ShippingTimeCalculator();
        ConstructingTimeCalculator constrCalc = new ConstructingTimeCalculator();
        Asia asia = new Asia();
        AutomaticGearBox auto = new AutomaticGearBox();

       protected override double GetShippingTime()
       {
            double shippingTimeFromAsia = shipCalc.GetShippingTime(asia);

            return shippingTimeFromAsia;
       }

        protected override double GetConstructingTime()
       {
            double constructingTimeA = constrCalc.GetConstructingTime(auto);
            
            return constructingTimeA;
       }
    }
}
