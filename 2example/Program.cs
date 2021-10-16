using System;

namespace _2_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Личное: 2 пример");
            int a;
            int b;
            int t;
            double s;   // Решение
            int i = 1;
            int o = 1;
            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("t=");
            t = Convert.ToInt32(Console.ReadLine());

            s = b * Math.Sin(i) * (a * Math.Pow(t, t) * Math.Cos(o) * 2 * t) - 1;   // Пример из задания

            Console.WriteLine("s=" + s);
            Console.ReadKey();

        }
    }
}
