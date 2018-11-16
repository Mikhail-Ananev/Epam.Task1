using System;
using System.Text;

namespace Task1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное целое нечетное число:");
            string str = Console.ReadLine();
            int x;
            bool result = Int32.TryParse(str, out x);

            if (result && x > 0 && x % 2 != 0)
            {
                ShowStars(x);
            }
            else
                Console.WriteLine("Введено некорректное значение.");
        }

        public static void ShowStars(int n)
        {
            var starString = new StringBuilder(n*n);
            for (int i = 0; i < n*n; i++)
            {
                if (i != 0 && i % n == 0)
                    {
                        starString.Append(Environment.NewLine);
                    }
                if (i != n * n / 2)
                    starString.Append('*');
                else starString.Append(' ');
            }
            Console.WriteLine(starString.ToString());
        }
    }
}
