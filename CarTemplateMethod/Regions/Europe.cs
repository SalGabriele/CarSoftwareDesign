using System.Collections.Generic;

namespace CarTemplateMethod.Regions
{
     class Europe: Region
    {
        private new Dictionary<string, double> distance = new Dictionary<string, double>()
            {
                {"France", 2267},
                {"Germany", 1324},
                {"UK", 2649}
            };
        private new double packingTime = 2.5;
        private new double unpackingTime = 1.5;
        private new int packingTimeDeflection = 10;
        private new int shippingTimeDeflection = 15;
        private new double shippingSpeed = 100;

        public override Dictionary<string, double> Distance { get { return distance; } set { distance = value; } }
        public override double PackingTime { get { return packingTime; } set { packingTime = value; } }
        public override double UnpackingTime { get { return unpackingTime; } set { unpackingTime = value; } }
        public override int PackingTimeDeflection { get { return packingTimeDeflection; } set { packingTimeDeflection = value; } }
        public override int ShippingTimeDeflection { get { return shippingTimeDeflection; } set { shippingTimeDeflection = value; } }
        public override double ShippingSpeed { get { return shippingSpeed; } set { shippingSpeed = value; } }
    }
}
