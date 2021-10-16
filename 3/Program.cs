using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 задание");
            Console.Write("Hour:");
            int h = Convert.ToInt32(Console.ReadLine());
            if (h > 12 || h < 1)
            {
                Console.WriteLine("Такой цифры нет на часах");
            }
            else
            {
                Console.Write("Minutes:");
                int m = Convert.ToInt32(Console.ReadLine());
                if (m > 60 || m < 1)
                {
                    Console.WriteLine("Такой цифры нет на часах");
                }
                else
                {
                    Console.Write("Seconds:");
                    int s = Convert.ToInt32(Console.ReadLine());
                    if (s > 60 || s < 1)
                    {
                        Console.WriteLine("Такой цифры нет на часах");
                    }
                    else
                    {
                        int sum = (h * 3600) + (m * 60) + s;
                        int corner = (sum / 10) % 360;
                        Console.WriteLine("Угол:" + corner + "Градусов");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
