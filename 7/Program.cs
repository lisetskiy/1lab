using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("7 задание");
            
            Console.WriteLine("Введите трехзначное число");
            int n = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (n < 100 | n > 999)
                {
                    Console.WriteLine("Введите трехзначное число");
                    break;
                }
                else
                {
                int a = (n / 100);
                int b = (n / 10) % 10;
                int c = (n % 10);


                Console.WriteLine($"Число :{a}{b}{c}");
                (a, b, c) = (c, b, a);
                Console.WriteLine($"reversed : {a}{b}{c}");
                break;
                }
               
            }
            
            Console.ReadKey();
        }
    }
}
