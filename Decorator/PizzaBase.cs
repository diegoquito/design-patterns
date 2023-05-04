
namespace Decorator
{
    public class PizzaBase : IPizza
    {
        public string GetDescription()
        {
            return "Pizza base";
        }

        public double CalculateCost()
        {
            return 5.0;
        }
    }
}
