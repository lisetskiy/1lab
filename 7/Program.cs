using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7 задание");
            int a;
            int b;
            int c;
            var m = new int[3];
            m[0] = a = 3;
            m[1] = b = 6;
            m[2] = c = 2;
            Console.WriteLine($"Число :{a}{b}{c}");
            (int c, int b, int a) p = (c, b, a);
            (a, b, c) = p;
            Console.WriteLine($"reversed : {a}{b}{c}");
            Console.ReadKey();
        }
    }
}
