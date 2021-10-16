using System;

namespace _1_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Личное: 1 пример");
            int a;
            int b;
            int t;
            double e = 2.7;
            double y;
            int s = 1;
            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("t=");
            t = Convert.ToInt32(Console.ReadLine());

            y = Math.Pow(e,-b * t) * Math.Sin(s) * (a * t + b) - (Math.Sqrt(Math.Abs(b * t + a))); // Пример из задания

            Console.WriteLine("y=" + y);
            Console.ReadKey();
        }
    }
}
