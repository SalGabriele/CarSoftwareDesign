using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    public abstract class CarFactory
    {   
        private double shippingTime;
        private double constructingTime;
        
        protected abstract double GetShippingTime();
        protected abstract double GetConstructingTime();
        
        public double GetTimeToMakeGearBox()
        {
            shippingTime = GetShippingTime();
            constructingTime = GetConstructingTime();
            return shippingTime + constructingTime;
        }
  
    }
}
