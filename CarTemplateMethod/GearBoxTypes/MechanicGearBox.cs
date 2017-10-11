using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTemplateMethod.GearBoxTypes;

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
    }
}
