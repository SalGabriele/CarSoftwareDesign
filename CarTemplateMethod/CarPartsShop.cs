using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    abstract class CarPartsShop
    {
        List<string> parts;
        int selectedPart;

        public abstract void PrintParts(List<string> parts);
        public abstract int SelectPart();
        public abstract void ConfirmPurchase(int selectedPart);

        public void PurchaseCarPart()
        {
            PrintParts(parts);
            selectedPart = SelectPart();
            ConfirmPurchase(selectedPart);
        }   
    }
}
