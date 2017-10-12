using CarTemplateMethod.GearBoxTypes;
using CarTemplateMethod.Regions;
using CarTemplateMethod.Calculators;

namespace CarTemplateMethod
{
    class AutomaticFromAsia: CarFactory
    {
        private ShippingTimeCalculator shipCalc = new ShippingTimeCalculator();
        private ConstructingTimeCalculator constrCalc = new ConstructingTimeCalculator();
        private Asia asia = new Asia();
        private AutomaticGearBox auto = new AutomaticGearBox();

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
