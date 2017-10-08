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
            {"France", 2267}, //km
            {"Germany", 1324},
            {"UK", 2649},
        };
        private Random rnd = new Random();

        private double packingTime = 2.5;
        private double shippingTime;
        private double unpackingTime = 1.5;
        private double allShippingTime;

        private int packingTimeDeflection = 10;
        private int shippingTimeDeflection = 15;
        private int shippingSpeed = 100; //km/h

        //*****************

        private double getReadyTime = 8.3;
        private double constructingTime = 20;
        private double finishingTime = 15;
        private double allConstructingTime;

        private int getReadyTimeDeflection = 5;
        private int constructingTimeDeflection = 20;
        private int finishingTimeDeflection = 45;

        protected override double GetShippingTime()
       {
            packingTime = DoDeflection(packingTime, packingTimeDeflection);
            var country = distance.ToList()[rnd.Next(distance.Count)];
            shippingTime = DoDeflection(country.Value/shippingSpeed, shippingTimeDeflection);
            unpackingTime = DoDeflection(unpackingTime, packingTimeDeflection);
            allShippingTime = packingTime + shippingTime + unpackingTime;

            Console.WriteLine("Gear Box details is packing " + packingTime + " hours");
            Console.WriteLine("Gear Box details is shipping from " + country.Key + " and it will take " + shippingTime + "hours");
            Console.WriteLine("Gear Box details is unpacking " + unpackingTime + " hours");
            Console.WriteLine("Gear Box in the Car Factory will be after " + allShippingTime + " hours");

            return allShippingTime;
       }

        protected override double GetConstructingTime()
       {
            getReadyTime = DoDeflection(getReadyTime, getReadyTimeDeflection);
            constructingTime = DoDeflection(constructingTime, constructingTimeDeflection);
            finishingTime = DoDeflection(finishingTime, finishingTimeDeflection);

            allConstructingTime = getReadyTime + constructingTime + finishingTime;

            Console.WriteLine("Getting ready takes " + getReadyTime + "hours");
            Console.WriteLine("Constructing Gear Box takes " + constructingTime + " hours");
            Console.WriteLine("Putting Gear Box to the car takes " + finishingTime + " hours");
            Console.WriteLine("Gear Box in the car will be after")

            return allConstructingTime;
       }

       private double DoDeflection(double value, int def)
       {
            value += (rnd.Next(-def, def))/100 * value;
            return value;
       }
    }
}
