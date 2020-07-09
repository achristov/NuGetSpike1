using System;

using Package1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new BaseClass();
            var v = x.Hello("BaGet");
            Console.WriteLine(v);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
