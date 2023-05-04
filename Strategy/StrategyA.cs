using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // Class that implements strategy A
    public class StrategyA : IStrategy
    {
        public void DoSomething()
        {
            Console.WriteLine("Strategy A has been executed");
        }
    }
}
