using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    public abstract class CarFactory
    {   
        public abstract void BuyDetails();
        public abstract void MakeGearBox();
        
        public void MakeCar()
        {
            BuyDetails();
            MakeGearBox();
        }
  
    }
}
