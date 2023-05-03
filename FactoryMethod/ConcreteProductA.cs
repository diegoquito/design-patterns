using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ConcreteProductA : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteProductA.Operation() called");
        }
    }
}
