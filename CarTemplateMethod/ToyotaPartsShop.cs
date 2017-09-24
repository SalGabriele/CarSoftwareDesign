using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    class ToyotaPartsShop: CarPartsShop
    {
        List<string> ToyotaParts = new List<string>()
        {
            "Engine",
            "ACCompressor",
            "Brakes",
            "Tires"
        };

        public override void PrintParts(List<string> parts)
        {
            int i = 1;
            foreach (string part in ToyotaParts)
            {
                Console.WriteLine(i + ". " + part);
                i++;
            }
        }

        public override int SelectPart()
        {
            int partNumber = Convert.ToInt32(Console.ReadLine());
            return partNumber;
        }

        public override void ConfirmPurchase(int selectedPart)
        {
            Console.WriteLine("Your selected part is " + ToyotaParts[selectedPart - 1]);
            Console.WriteLine("Purchase is confirmed");
        }
    }
}
