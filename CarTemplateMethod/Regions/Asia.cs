using System.Collections.Generic;

namespace CarTemplateMethod.Regions
{
    class Asia : Region
    {
        private Dictionary<string, double> distance = new Dictionary<string, double>()
            {
                {"Japan", 8122},
                {"China", 6237.27}
            };
        private double packingTime = 1;
        private double unpackingTime = 1.5;
        private int packingTimeDeflection = 1;
        private int shippingTimeDeflection = 5;
        private double shippingSpeed = 200;


        public override Dictionary<string, double> Distance { get { return distance; } set { distance = value; } }
        public override double PackingTime { get { return packingTime; } set { packingTime = value; } }
        public override double UnpackingTime { get { return unpackingTime; } set { unpackingTime = value; } }
        public override int PackingTimeDeflection { get { return packingTimeDeflection; } set { packingTimeDeflection = value; } }
        public override int ShippingTimeDeflection { get { return shippingTimeDeflection; } set { shippingTimeDeflection = value; } }
        public override double ShippingSpeed { get { return shippingSpeed; } set { shippingSpeed = value; } }
    }
}
