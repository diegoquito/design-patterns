using Strategy;


// Create an instance of the strategies

IStrategy strategyA = new StrategyA();
IStrategy strategyB = new StrategyB();

// Create an instance of the context and assign a strategy to it
Context context = new Context(strategyA);

//  Execute the action with the current strategy
context.DoSomething(); // Prints "Strategy A has been executed."

// Change context strategy
context.SetStrategy(strategyB);

// Execute the action with the new strategy
context.DoSomething(); // Prints "Strategy B has been executed."

