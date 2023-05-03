using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ConcreteProductB : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteProductB.Operation() called");
        }
    }
}
