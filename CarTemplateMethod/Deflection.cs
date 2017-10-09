using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    static class Deflection
    {
        public static Random rnd = new Random();

        public static double Do(double value, int def)
        {
            value += (rnd.Next(-def, def))/100 * value;
            return value;
        }
    }
}
