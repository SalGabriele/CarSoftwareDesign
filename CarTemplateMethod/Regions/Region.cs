using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarTemplateMethod.Regions
{
    abstract class Region
    {
        public Dictionary<string, double> distance;
        public double packingTime;
        public double unpackingTime;
        public int packingTimeDeflection;
        public int shippingTimeDeflection;
        public double shippingSpeed;
    }
}
