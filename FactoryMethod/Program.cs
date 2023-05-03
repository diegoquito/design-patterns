using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Creator creator;
            IProduct product;

            creator = new ConcreteCreatorA();
            product = creator.FactoryMethod();
            product.Operation();

            creator = new ConcreteCreatorB();
            product = creator.FactoryMethod();
            product.Operation();
        }
    }
    
}
