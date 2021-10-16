using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            int data;
            int hour;
            int hourrest;
            int min;
            Console.Write("Введите число:");
            data = Convert.ToInt32(Console.ReadLine());
            if (data < 0)
            {
                Console.Write("Время не может быть отрицательным");
            }
            if (data != 0)
            {
                hour = data / 3600;
                Console.WriteLine("Часы" + hour);
                hourrest = data % 3600;
                min = hourrest / 60;
                Console.WriteLine("Минуты" + min);
            }

        }
    }
}
