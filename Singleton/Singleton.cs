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

        // The Singleton's constructor should always be private to prevent
        // Constructor privado para evitar que se instancie la clase desde fuera
        private Singleton() { }

        // This is the static method that controls the access to the singleton instance
        // Método para obtener la instancia del Singleton
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        // Example method to show how to use singleton
        // Método de ejemplo que muestra cómo se utiliza el Singleton
        public void ExampleMethod()
        {
            Console.WriteLine("This is singleton example");
        }
    }
}
