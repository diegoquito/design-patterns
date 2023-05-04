using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // Class that implements strategy B
    public class StrategyB : IStrategy
    {
        public void DoSomething()
        {
            Console.WriteLine("Strategy B has been executed");
        }
    }
}
