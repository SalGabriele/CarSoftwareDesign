using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod.Regions
{
     class Europe: Region
    {
        public new Dictionary<string, double>distance = new Dictionary<string, double>()
            {
                {"France", 2267},
                {"Germany", 1324},
                {"UK", 2649}
            };
        public new double packingTime = 2.5;
        public new double unpackingTime = 1.5;
        public new int packingTimeDeflection = 10;
        public new int shippingTimeDeflection = 15;
        public new double shippingSpeed = 100;
    }
}
