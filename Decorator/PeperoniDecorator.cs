
namespace Decorator
{
    public class PeperoniDecorator : PizzaDecorator
    {
        public PeperoniDecorator(IPizza pizza) : base(pizza) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Peperoni";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 1.75;
        }
    }
}
