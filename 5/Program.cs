using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5");
            int a;
            int b;
            int S;
            int v;
            int vv;
            int P;
            Console.Write("Введите a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Катет не может быть отрицательным");
            }
            if (b <= 0)
            {
                Console.WriteLine("Катет не может быть отрицательным");
            }

            S = (a * b) / 2;
            Console.WriteLine("S =" + S);
            v = (int)Math.Pow(a, 2);
            vv = (int)Math.Pow(b, 2);
            P = (int)Math.Sqrt(v + vv);
            Console.WriteLine("P =" + P);
            Console.ReadKey();
        }
    }
}
