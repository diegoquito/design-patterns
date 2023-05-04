using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MushroomDecorator : PizzaDecorator
    {
        public MushroomDecorator(IPizza pizza) : base(pizza){}

        public override string GetDescription()
        {
            return base.GetDescription() + ", mushrooms";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 1.0;
        }
    }
}
