using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTemplateMethod.Regions;

namespace CarTemplateMethod.Calculators
{
    class ShippingTimeCalculator
    {
       public double GetShippingTime(Region reg)
       {
            reg.packingTime = Deflection.Do(reg.packingTime, reg.packingTimeDeflection);
            var country = reg.distance.ToList()[Deflection.rnd.Next(reg.distance.Count)];
            double shipping = Deflection.Do(country.Value/reg.shippingSpeed, reg.shippingTimeDeflection);
            Console.WriteLine("Gear Box details is shipping from ");
            reg.unpackingTime = Deflection.Do(reg.unpackingTime, reg.packingTimeDeflection);
            double shippingTime = reg.packingTime + shipping + reg.unpackingTime;
            PrintShippingTime(reg.packingTime, shipping, reg.unpackingTime);
            return shippingTime;
       }

       private void PrintShippingTime(double packing, double shipping, double unpacking)
        {
            Console.WriteLine("Gear Box details is packing " + packing + " hours");
            Console.WriteLine("Shipping will take " + shipping + "hours");
            Console.WriteLine("Gear Box details is unpacking " + unpacking + " hours");
        }

    }
}
