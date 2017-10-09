using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    class ConstructingTimeCalculator
    {
        protected double GetConstructingTime(double getReadyTime, double constructingTime, double finishingTime)
       {
            getReadyTime = DoDeflection(getReadyTime, getReadyTimeDeflection);
            constructingTime = DoDeflection(constructingTime, constructingTimeDeflection);
            finishingTime = DoDeflection(finishingTime, finishingTimeDeflection);
            allConstructingTime = getReadyTime + constructingTime + finishingTime;

            return allConstructingTime;
       }
    }
}
