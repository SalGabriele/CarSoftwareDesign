namespace CarTemplateMethod.GearBoxTypes
{
    class AutomaticGearBox: GearBoxType
    {
        private double getReadyTime = 8.3;
        private double constructingTime = 20;
        private double finishingTime = 15;
        private int getReadyTimeDeflection = 5;
        private int constructingTimeDeflection = 20;
        private int finishingTimeDeflection = 45;

        public override double GetReadyTime { get { return getReadyTime; } set { getReadyTime = value; } }
        public override double ConstructingTime { get { return constructingTime; } set { constructingTime = value; } }
        public override double FinishingTime { get { return finishingTime; } set { finishingTime = value; } }
        public override int GetReadyTimeDeflection { get { return getReadyTimeDeflection; } set { getReadyTimeDeflection = value; } }
        public override int ConstructingTimeDeflection { get { return constructingTimeDeflection; } set { constructingTimeDeflection = value; } }
        public override int FinishingTimeDeflection { get { return finishingTimeDeflection; } set { finishingTimeDeflection = value; } }
    }
}
