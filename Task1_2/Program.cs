using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное целое число:");
            string str = Console.ReadLine();
            int x;
            bool result = Int32.TryParse(str, out x);

            if (result && x > 0)
            {
                if (IsSimple(x))
                    Console.WriteLine("{0} является простым числом.", x);
                else
                    Console.WriteLine("{0} не является простым числом.", x);
            }
            else
                Console.WriteLine("Введено некорректное значение.");

        }

        public static bool IsSimple(int n)
        {
            int count = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    count++;
            }
            if (count > 1)
                return false;
            else
                return true;
        }
    }
}
