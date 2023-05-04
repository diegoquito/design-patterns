
namespace Decorator
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Cheese";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 1.5;
        }
    }
}
