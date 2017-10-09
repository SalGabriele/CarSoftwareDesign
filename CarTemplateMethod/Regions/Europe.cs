using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod.Regions
{
    static class Europe
    {
        public static Dictionary<string, double>distance = new Dictionary<string, double>()
            {
                {"France", 2267},
                {"Germany", 1324},
                {"UK", 2649}
            };
        public static double packingTime = 2.5;
        public static double unpackingTime = 1.5;
        public static int packingTimeDeflection = 10;
        public static int shippingTimeDeflection = 15;
        public static double shippingSpeed = 100;
    }
}
