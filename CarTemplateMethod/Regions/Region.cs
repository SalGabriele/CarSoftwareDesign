using System.Collections.Generic;

namespace CarTemplateMethod.Regions
{
    abstract class Region
    {
        public abstract Dictionary<string, double> Distance { get; set; }
        public abstract double PackingTime { get; set; }
        public abstract double UnpackingTime { get; set; }
        public abstract int PackingTimeDeflection { get; set; }
        public abstract int ShippingTimeDeflection { get; set; }
        public abstract double ShippingSpeed { get; set; }
    }
}
