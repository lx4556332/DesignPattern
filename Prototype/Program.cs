using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = Signleton.GetInstance();
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(instance.GetDateTimeNow().ToString());
                Console.WriteLine($"======={ instance.GetHashCode()}=======");
                System.Threading.Thread.Sleep(100);
            }
            Console.ReadLine();
        }
    }
}
