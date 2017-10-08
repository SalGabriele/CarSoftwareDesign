using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    class BMWPartsShop: CarFactory
    {
        private Dictionary<string, double> distance = new Dictionary<string, double>()
        {
            {"France", 2267},
            {"Germany", 1324},
            {"UK", 2649},
        };

        private double packingTime = 2.5;
        private double shippingTime;
        private double unpackingTime;

        private int packingTimeDeflection = 10;
        private Random rnd = new Random();
        
        protected override double GetShippingTime()
       {
           packingTime += (rnd.Next(-packingTimeDeflection, packingTimeDeflection))/100 * packingTime;
           var country = distance.ToList()[rnd.Next(distance.Count)];
           Console.WriteLine("Gear Box details is shipping from " + country.Key + "...");
           shippingTime = 
            //country is country.Key
            //distance is country.Value
       }

        protected override double GetConstructingTime()
       {
           //make automatic gear box
       }
    }
}
