using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    class AutomaticFromAsia: CarFactory
    {
       protected override double GetShippingTime()
       {
            distance = new Dictionary<string, double>()
            {
                {"Japan", 8122},
                {"China", 6237.27}
            };
            
            packingTime = 1;
            unpackingTime = 1.5;
            packingTimeDeflection = 1;
            shippingTimeDeflection = 5;
            shippingSpeed = 200;

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
            getReadyTime = 8.3;
            constructingTime = 20;
            finishingTime = 15;
            getReadyTimeDeflection = 5;
            constructingTimeDeflection = 20;
            finishingTimeDeflection = 45;

            getReadyTime = DoDeflection(getReadyTime, getReadyTimeDeflection);
            constructingTime = DoDeflection(constructingTime, constructingTimeDeflection);
            finishingTime = DoDeflection(finishingTime, finishingTimeDeflection);
            allConstructingTime = getReadyTime + constructingTime + finishingTime;

            return allConstructingTime;
       }
    }
}
