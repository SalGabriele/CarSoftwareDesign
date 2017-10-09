using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    public abstract class CarFactory
    {   
        protected Random rnd = new Random();

        //Region based variables
        protected Dictionary<string, double> distance;
        
        protected double packingTime;
        protected double shippingTime;
        protected double unpackingTime;
        protected double allShippingTime;

        protected int packingTimeDeflection;
        protected int shippingTimeDeflection;
        protected int shippingSpeed;

        //Gear Box Type based variables
        protected double getReadyTime;
        protected double constructingTime;
        protected double finishingTime;
        protected double allConstructingTime;

        protected int getReadyTimeDeflection;
        protected int constructingTimeDeflection;
        protected int finishingTimeDeflection;
        
        protected abstract double GetShippingTime();
        protected abstract double GetConstructingTime();
        
        public double GetTimeToMakeGearBox()
        {
            shippingTime = GetShippingTime();
            PrintShippingTime();
            constructingTime = GetConstructingTime();
            PrintConstructingTime();
            return shippingTime + constructingTime;
        }

        private void PrintShippingTime()
        {
            Console.WriteLine("Gear Box details is packing " + packingTime + " hours");
            Console.WriteLine("Shipping will take " + shippingTime + "hours");
            Console.WriteLine("Gear Box details is unpacking " + unpackingTime + " hours");
            Console.WriteLine("Gear Box in the Car Factory will be after " + allShippingTime + " hours");
        }
        private void PrintConstructingTime()
        {
            Console.WriteLine("Getting ready takes " + getReadyTime + "hours");
            Console.WriteLine("Constructing Gear Box takes " + constructingTime + " hours");
            Console.WriteLine("Putting Gear Box to the car takes " + finishingTime + " hours");
            Console.WriteLine("Gear Box in the car will be after");
        }
        protected double DoDeflection(double value, int def)
        {
            value += (rnd.Next(-def, def))/100 * value;
            return value;
        }
  
    }
}
