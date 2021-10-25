\ Console.WriteLine("Личное: Таблица");

using System;
using System.Collections;

namespace Table
{
    public class OOP
    {
        public enum Type
        {
            А, И, Т
        }
        public class Item
        {
            public string show;
            public string leader;
            public int rating;
            public Type type1;

            public Item(string show, string leader, int rating, Type type1)
            {
                this.show = show;
                this.leader = leader;
                this.rating = rating;
                this.type1 = type1;
            }

            public void Print()
            {
                Console.WriteLine($"|{this.show,-24}|{this.leader,-12}|{this.rating,-20}|{this.type1,-15}|");
            }
        }

        private static void Main()
        {
            ArrayList list = new();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Передача:");
                string show = Console.ReadLine();

                Console.WriteLine("Ведущий");
                string leader = Console.ReadLine();

                Console.WriteLine("Рейтинг:");
                int rating = Convert.ToInt32(Console.ReadLine());

                Type type1;
                while (true)
                {
                    Console.WriteLine("Тип(А,И,Т):");
                    string tmp = Console.ReadLine();
                    if (tmp == "А" || tmp == "A")
                    {
                        type1 = Type.А;
                        break;
                    }
                    else if (tmp == "И" || tmp == "B")
                    {
                        type1 = Type.И;
                        break;
                    }
                    else if (tmp == "Т" || tmp == "Т")
                    {
                        type1 = Type.Т;
                        break;
                    }
                    else Console.WriteLine("Введите еще раз.");

                }

                Item value = new(show, leader, rating, type1);
                list.Add(value);
                while (true)
                {
                    Console.WriteLine("Добавить элементы в таблицу?\nда - продолжить\nнет - вывод таблицы");
                    string input = Console.ReadLine();
                    if (input == "да" || input == "нет")
                    {
                        if (input == "нет")
                        {
                           flag = false;
                           break;
                        }
                        break;
                    } 
                    else Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
                }

                
            }
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Телепередача",-75}|");
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Передача",-25}|{"Ведущий",-12}|{"Рейтинг",-20}|{"Тип",-15}|");
            Console.WriteLine(new String('-', 76));
            foreach (Item item in list)
            {
                item.Print();
                Console.WriteLine(new String('-', 76));
            }
            Console.WriteLine($"{"|Перечисляемый тип: И - игровая; А - аналитическая; Т - ток-шоу",-75}|");
            Console.WriteLine(new String('-', 76));


        }
    }
}
