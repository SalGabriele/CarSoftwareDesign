namespace CarTemplateMethod.GearBoxTypes
{
    class MechanicGearBox: GearBoxType
    {
        private double getReadyTime = 3;
        private double constructingTime = 25;
        private double finishingTime = 7;
        private int getReadyTimeDeflection = 6;
        private int constructingTimeDeflection = 22;
        private int finishingTimeDeflection = 10;

        public override double GetReadyTime { get { return getReadyTime; } set { getReadyTime = value; } }
        public override double ConstructingTime { get { return constructingTime; } set { constructingTime = value; } }
        public override double FinishingTime { get { return finishingTime; } set { finishingTime = value; } }
        public override int GetReadyTimeDeflection { get { return getReadyTimeDeflection; } set { getReadyTimeDeflection = value; } }
        public override int ConstructingTimeDeflection { get { return constructingTimeDeflection; } set { constructingTimeDeflection = value; } }
        public override int FinishingTimeDeflection { get { return finishingTimeDeflection; } set { finishingTimeDeflection = value; } }
    }
}
