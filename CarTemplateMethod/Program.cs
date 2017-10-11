using System;

namespace CarTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AutomaticFromAsia");
            CarFactory autoAsia = new AutomaticFromAsia();
            autoAsia.GetTimeToMakeGearBox();

            Console.WriteLine("\nAutomaticFromEurope");
            CarFactory autoEurope = new AutomaticFromEurope();
            autoEurope.GetTimeToMakeGearBox();

            Console.WriteLine("\nMechanicFromAsia");
            CarFactory mechAsia = new MechanicFromAsia();
            mechAsia.GetTimeToMakeGearBox();

            Console.WriteLine("\nMechanicFromEurope");
            CarFactory mechEurope = new MechanicFromEurope();
            mechEurope.GetTimeToMakeGearBox();

            Console.ReadKey();
        }
    }
}
