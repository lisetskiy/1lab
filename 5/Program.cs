  Console.WriteLine("Задание 5");
            int a;
            int b;
            int S;
            double P0;
            int P;
            Console.Write("Введите a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b:");
            b = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (a <= 0 | b <= 0)
                {
                    Console.WriteLine("Катет не может быть отрицательным");
                    break;
                }
                else
                {
                    S = (a * b) / 2;
                    Console.WriteLine("S =" + S);
                    c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    P = (int)(a + b + c);

                    Console.WriteLine("P =" + P);
                    break;

                }
            }
           
            Console.ReadKey();
