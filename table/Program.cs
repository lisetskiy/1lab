using System;

namespace table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Личное: Таблица");

            Console.WriteLine("Введите данные первой строки");
            Console.Write("Передача:");
            string Show1 = Console.ReadLine();
            Console.Write("Ведущий:");
            string leader1 = Console.ReadLine();
            Console.Write("Рейтинг:");
            int rating1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Тип:");
            string Type1 = Console.ReadLine();

            Console.WriteLine("Введите данные второй строки");
            Console.Write("Передача:");
            string Show2 = Console.ReadLine();
            Console.Write("Ведущий:");
            string leader2 = Console.ReadLine();
            Console.Write("Рейтинг:");
            int rating2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Тип:");
            string Type2 = Console.ReadLine();

            Console.WriteLine("Введите данные третьей строки");
            Console.Write("Передача:");
            string Show3 = Console.ReadLine();
            Console.Write("Ведущий:");
            string leader3 = Console.ReadLine();
            Console.Write("Рейтинг:");
            int rating3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Тип:");
            string Type3 = Console.ReadLine();

            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("|Телепередача                                                  |");
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("|Передача   |Ведущий        |               |                  |");
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("|" + Show1 + "|" + leader1 + "|" + rating1 + "|" + Type1 + "|");
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("|" + Show2 + "|" + leader2 + "|" + rating2 + "|" + Type2 + "|");
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("|" + Show3 + "|" + leader3 + "|" + rating3 + "|" + Type3 + "|");
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("|Перечисляемый тип: И - игровая; А - аналитическая; Т - ток-шоу|");

            Console.ReadKey();
        }
    }
}
