using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod.Calculators
{
    class ShippingTimeCalculator
    {
       public double GetShippingTime(Dictionary<string, double> dist, double packing, int packingD, double shippingS, int shippingD, double unpacking)
       {
            packing = Deflection.Do(packing, packingD);
            var country = dist.ToList()[Deflection.rnd.Next(dist.Count)];
            double shipping = Deflection.Do(country.Value/shippingS, shippingD);
            Console.WriteLine("Gear Box details is shipping from " + country.Key + " and it will take " + shipping + "hours");
            unpacking = Deflection.Do(unpacking, packingD);
            double shippingTime = packing + shipping + unpacking;
            PrintShippingTime(packing, shipping, unpacking);
            return shippingTime;
       }

       private void PrintShippingTime(double packing, double shipping, double unpacking)
        {
            Console.WriteLine("Gear Box details is packing " + packing + " hours");
            Console.WriteLine("Shipping will take " + shippingTime + "hours");
            Console.WriteLine("Gear Box details is unpacking " + unpacking + " hours");
        }

    }
}
