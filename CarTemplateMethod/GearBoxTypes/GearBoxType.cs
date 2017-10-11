namespace CarTemplateMethod.GearBoxTypes
{
    abstract class GearBoxType
    {
        public abstract double GetReadyTime { get; set; }
        public abstract double ConstructingTime { get; set; }
        public abstract double FinishingTime { get; set; }
        public abstract int GetReadyTimeDeflection { get; set; }
        public abstract int ConstructingTimeDeflection { get; set; }
        public abstract int FinishingTimeDeflection { get; set; }
    }
}
