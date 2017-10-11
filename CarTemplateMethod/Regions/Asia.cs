using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod.Regions
{
    class Asia: Region
    {
        public new Dictionary<string, double> distance = new Dictionary<string, double>()
            {
                {"Japan", 8122},
                {"China", 6237.27}
            };
        private new double packingTime = 1;
        public new double unpackingTime = 1.5;
        public new int packingTimeDeflection = 1; // <---
        public new int shippingTimeDeflection = 5;
        public new double shippingSpeed = 200;

        public double PackingTime { get; set; };
            


    }
}
