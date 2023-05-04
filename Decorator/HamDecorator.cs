using System;
using System.Collections.Generic;


namespace Decorator
{
    public class HamDecorator : PizzaDecorator
    {
        public HamDecorator(IPizza pizza) : base(pizza) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Ham";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 1.70;
        }
    }
}
