using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    public abstract class CarFactory
    {         
        protected abstract double GetShippingTime();
        protected abstract double GetConstructingTime();
        
        public void GetTimeToMakeGearBox()
        {
            double shippingTime = GetShippingTime();
            Console.WriteLine("Gear Box in the Car Factory will be after " + shippingTime + " hours");
            double constructingTime = GetConstructingTime();
            Console.WriteLine("Constucting will take " + constructingTime + " hours");
            Console.WriteLine("You can take your car after " + shippingTime + constructingTime + " hours");
        }
    }
}
