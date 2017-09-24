﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    class BMWPartsShop: CarPartsShop
    {
        public BMWPartsShop()
        {
            Console.WriteLine("BMW Parts Shop is selected");
        }

        List<string> BMWParts = new List<string>()
        {
            "Engine",
            "Brakes"
        };

        public override void PrintParts(List<string> parts)
        {
            int i = 1;
            foreach (string part in BMWParts)
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
            Console.WriteLine("Your selected part is " + BMWParts[selectedPart - 1]);
            Console.WriteLine("Purchase is confirmed");
        }
    }
}
