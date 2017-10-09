using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory autoAsia = new AutomaticFromAsia();
            autoAsia.GetTimeToMakeGearBox();

            CarFactory autoEurope = new AutomaticFromEurope();
            autoEurope.GetTimeToMakeGearBox();

            CarFactory mechAsia = new MechanicFromAsia();
            mechAsia.GetTimeToMakeGearBox();

            CarFactory mechEurope = new MechanicFromEurope();
            mechEurope.GetTimeToMakeGearBox();
        }
    }
}
