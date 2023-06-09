﻿

namespace Strategy
{
    // Class using the strategy
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void DoSomething()
        {
            _strategy.DoSomething();
        }
    }

}
