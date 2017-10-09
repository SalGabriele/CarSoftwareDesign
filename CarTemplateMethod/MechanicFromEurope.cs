using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    class MechanicFromEurope: CarFactory
    {
        private ShippingTimeCalculator shipping;
        private ConstructingTimeCalculator constructing;
       
       protected override double GetShippingTime()
       {
            distance = new Dictionary<string, double>()
            {
                {"France", 2267},
                {"Germany", 1324},
                {"UK", 2649}
            };
            packingTime = 2.5;
            unpackingTime = 1.5;
            packingTimeDeflection = 10;
            shippingTimeDeflection = 15;
            shippingSpeed = 100;

            shippingTime = shipping.GetShippingTime(distance, packingTime, packingTimeDeflection, shippingSpeed, shippingTimeDeflection, unpackingTime);

            return shippingTime;
       }

        protected override double GetConstructingTime()
       {
            //public double GetConstructingTime(double ready, int readyD, double construct, int constructD, double finish, int finishD)

            return constructingTime;
       }
    }
}
