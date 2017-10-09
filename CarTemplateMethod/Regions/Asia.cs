using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod.Regions
{
    static class Asia
    {
        public static Dictionary<string, double> distance = new Dictionary<string, double>()
            {
                {"Japan", 8122},
                {"China", 6237.27}
            };
        public static double packingTime = 1;
        public static double unpackingTime = 1.5;
        public static int packingTimeDeflection = 1;
        public static int shippingTimeDeflection = 5;
        public static double shippingSpeed = 200;
    }
}
