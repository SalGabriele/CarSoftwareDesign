using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TEST
namespace CarTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Car Brand:");
            int a = GetBrandNumber();
            CarSwitch(a);
            Console.ReadKey();
        }

        static int GetBrandNumber()
        {
            Console.WriteLine("1. BMW");
            Console.WriteLine("2. Toyota");

            int brandNumber = Convert.ToInt32(Console.ReadLine());
            return brandNumber;
        }

        static void CarSwitch(int brand)
        {
            switch (brand)
            {
                case 1:
                    CarPartsShop car = new BMWPartsShop();
                    car.PurchaseCarPart();
                    break;
                case 2:
                    car = new ToyotaPartsShop();
                    car.PurchaseCarPart();
                    break;
                default:
                    Console.WriteLine("Wrong choice. Try again");
                    int a = GetBrandNumber();
                    CarSwitch(a);
                    break;
            }
        }
    }
}
