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
        protected int shippingSpeed; //km/h

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
            
        }
        private void PrintConstructingTime()
        {

        }
  
    }
}
