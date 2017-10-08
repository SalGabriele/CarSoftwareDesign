using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    class AutomaticFromAsia: CarFactory
    {
        private Random rnd = new Random();
       
       //Asia variables
        private Dictionary<string, double> distance = new Dictionary<string, double>()
        {
            {"Japan", 8122}, //km 
            {"China", 6237.27}
        };
        
        private double packingTime = 1;
        private double shippingTime; 
        private double unpackingTime = 1.5;
        private double allShippingTime;

        private int packingTimeDeflection = 1;
        private int shippingTimeDeflection = 5;
        private int shippingSpeed = 200;
       
       //Automatic Gear Box variables
        private double getReadyTime = 8.3;
        private double constructingTime = 20;
        private double finishingTime = 15;
        private double allConstructingTime;

        private int getReadyTimeDeflection = 5;
        private int constructingTimeDeflection = 20;
        private int finishingTimeDeflection = 45;
       
       protected override double GetShippingTime()
       {
           //buy from Asia
           //
       }

        protected override double GetConstructingTime()
       {
           //make automatic gear box
       }
    }
}
