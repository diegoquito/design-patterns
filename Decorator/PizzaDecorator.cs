
namespace Decorator
{
    public abstract class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;
        protected PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string GetDescription()
        {
            return _pizza.GetDescription();
        }

        public virtual double CalculateCost()
        {
            return _pizza.CalculateCost();
        }
    }
}
