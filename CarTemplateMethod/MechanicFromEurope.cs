using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    class MechanicFromEurope: CarFactory
    {
       protected override double GetShippingTime()
       {
            distance = new Dictionary<string, double>()
            {
                {"France", 2267}, //km
                {"Germany", 1324},
                {"UK", 2649}
            };
            packingTime = 2.5;
            unpackingTime = 1.5;
            packingTimeDeflection = 10;
            shippingTimeDeflection = 15;
            shippingSpeed = 100;

            packingTime = DoDeflection(packingTime, packingTimeDeflection);
            var country = distance.ToList()[rnd.Next(distance.Count)];
            Console.WriteLine("Gear Box details is shipping from " + country.Key + " and it will take " + shippingTime + "hours");
            shippingTime = DoDeflection(country.Value/shippingSpeed, shippingTimeDeflection);
            unpackingTime = DoDeflection(unpackingTime, packingTimeDeflection);
            allShippingTime = packingTime + shippingTime + unpackingTime;

            return allShippingTime;
       }

        protected override double GetConstructingTime()
       {
            getReadyTime = 3;
            constructingTime = 25;
            finishingTime = 7;
            getReadyTimeDeflection = 6;
            constructingTimeDeflection = 22;
            finishingTimeDeflection = 10;

            getReadyTime = DoDeflection(getReadyTime, getReadyTimeDeflection);
            constructingTime = DoDeflection(constructingTime, constructingTimeDeflection);
            finishingTime = DoDeflection(finishingTime, finishingTimeDeflection);
            allConstructingTime = getReadyTime + constructingTime + finishingTime;

            return allConstructingTime;
       }
    }
}
