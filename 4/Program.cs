using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 задание");
            int a = 1;
            int b = 2;
            Console.WriteLine($"a ->{a} = b ->{b}");
            (a, b) = (b, a);
            Console.WriteLine($"a ->{a} = b ->{b}");
            Console.ReadKey();
        }
    }
}
