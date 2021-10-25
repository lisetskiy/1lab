namespace _2
{    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число");
            
            Console.WriteLine("Число");
            int n = Convert.ToInt32(Console.ReadLine());
            
            while (true)
            {
                if(n > 9999 | n< 1000)
                {
                    Console.WriteLine("Введите четырехзначное число");
                    break;
                }
                else
                {
                    int a = n % 10;
                    int b = (n / 10) % 10;
                    int c = (n / 100) % 10;
                    int d = (n / 1000);
                    int res = a * b * c * d;
                    Console.WriteLine("answer" + res);

                    break;
                }
            }
          
            Console.ReadKey();
        }
    }   
}
