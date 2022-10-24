using System;

namespace Module3HW5
{
    public class Program
    {
        public static void Main()
        {
            Methods methods = new Methods();
            string helloWorld = methods.GetAllTextAsync().Result;
            Console.WriteLine(helloWorld);
        }
    }
}
