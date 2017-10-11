using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod.GearBoxTypes
{
    class AutomaticGearBox: GearBoxType
    {
        public double getReadyTime = 8.3;
        public double constructingTime = 20;
        public double finishingTime = 15;
        public int getReadyTimeDeflection = 5;
        public int constructingTimeDeflection = 20;
        public int finishingTimeDeflection = 45;
    }
}
