using System;
using System.Linq;
using CarTemplateMethod.Regions;

namespace CarTemplateMethod.Calculators
{
    class ShippingTimeCalculator
    {
       public double GetShippingTime(Region reg)
       {
            reg.PackingTime = Deflection.Do(reg.PackingTime, reg.PackingTimeDeflection);
            var country = reg.Distance.ToList()[Deflection.rnd.Next(reg.Distance.Count)];
            double shipping = Deflection.Do(country.Value/reg.ShippingSpeed, reg.ShippingTimeDeflection);
            Console.WriteLine("Gear Box details is shipping from " + country.Key);
            reg.UnpackingTime = Deflection.Do(reg.UnpackingTime, reg.PackingTimeDeflection);
            double shippingTime = reg.PackingTime + shipping + reg.UnpackingTime;
            PrintShippingTime(reg.PackingTime, shipping, reg.UnpackingTime);
            return shippingTime;
       }

       private void PrintShippingTime(double packing, double shipping, double unpacking)
        {
            Console.WriteLine("Gear Box details is packing " + packing + " hours");
            Console.WriteLine("Shipping will take " + shipping + " hours");
            Console.WriteLine("Gear Box details is unpacking " + unpacking + " hours");
        }

    }
}
