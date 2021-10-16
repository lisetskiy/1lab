using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("8 задание");
            Console.Write("x :");
            int x = Convert.ToInt32(Console.ReadLine());
            int res;
            res = 3 * x ^ 4 - 5 * x ^ 3 + 2 * x ^ 2 - x + 7;
            Console.WriteLine("res =" + res);
            Console.ReadKey();
        }
    }
}
