namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

                  
            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }

            s1.ExampleMethod();
            s2.ExampleMethod();
        }
    }
}