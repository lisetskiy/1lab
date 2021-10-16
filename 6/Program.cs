using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6 задание");
            Console.WriteLine("Введите строго четырех значное число");
            Console.WriteLine("Введите число:");
            int a;
            int b;
            int c;
            int d;
            int res;
            var m = new int[4];
            m[0] = a = 1;
            m[1] = b = 2;
            m[2] = c = 3;
            m[3] = d = 4;
            res = a * b * c * d;
            Console.WriteLine("res:" + res);
            Console.ReadKey();
        }
    }
}
