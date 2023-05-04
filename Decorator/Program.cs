

using Decorator;

IPizza pizza = new PizzaBase();
Console.WriteLine(pizza.GetDescription() + " - $" + pizza.CalculateCost());


pizza = new HamDecorator(pizza);
Console.WriteLine(pizza.GetDescription() + " - $" + pizza.CalculateCost());


pizza = new PeperoniDecorator(pizza);
Console.WriteLine(pizza.GetDescription() + " - $" + pizza.CalculateCost());


pizza = new CheeseDecorator(pizza);
Console.WriteLine(pizza.GetDescription() + " - $" + pizza.CalculateCost());


pizza = new MushroomDecorator(pizza);
Console.WriteLine(pizza.GetDescription() + " - $" + pizza.CalculateCost());
