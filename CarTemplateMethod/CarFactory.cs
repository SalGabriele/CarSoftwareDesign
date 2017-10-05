using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTemplateMethod
{
    public abstract class CarFactory
    {   
        protected abstract void BuyDetails();
        protected abstract void MakeGearBox();
        
        public void MakeCar()
        {
            BuyDetails();
            MakeGearBox();
        }
  
    }
}
