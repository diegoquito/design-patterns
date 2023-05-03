using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton? _instance;

        // Constructor privado para evitar que se instancie la clase desde fuera
        private Singleton() { }

        // Método para obtener la instancia del Singleton
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        // Método de ejemplo que muestra cómo se utiliza el Singleton
        public void ExampleMethod()
        {
            Console.WriteLine("This is singleton example");
        }
    }
}
