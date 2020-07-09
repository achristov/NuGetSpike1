using System;

using MyPackage;

namespace ConsoleApp2
{
    internal static class Program
    {
        private static void Main()
        {
            var demo = new Demo();
            var greetings = demo.Hello("NuGet");
            Console.WriteLine(greetings);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}