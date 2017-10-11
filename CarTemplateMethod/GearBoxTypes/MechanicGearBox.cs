namespace CarTemplateMethod.GearBoxTypes
{
    class MechanicGearBox: GearBoxType
    {
        public double getReadyTime = 3;
        public double constructingTime = 25;
        public double finishingTime = 7;
        public int getReadyTimeDeflection = 6;
        public int constructingTimeDeflection = 22;
        public int finishingTimeDeflection = 10;

        public override double GetReadyTime { get { return getReadyTime; } set { getReadyTime = value; } }
        public override double ConstructingTime { get { return constructingTime; } set { constructingTime = value; } }
        public override double FinishingTime { get { return finishingTime; } set { finishingTime = value; } }
        public override int GetReadyTimeDeflection { get { return getReadyTimeDeflection; } set { getReadyTimeDeflection = value; } }
        public override int ConstructingTimeDeflection { get { return constructingTimeDeflection; } set { constructingTimeDeflection = value; } }
        public override int FinishingTimeDeflection { get { return finishingTimeDeflection; } set { finishingTimeDeflection = value; } }
    }
}
