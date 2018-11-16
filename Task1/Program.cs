using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1
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
                Console.WriteLine(Show(x));
            }
            else
                Console.WriteLine("Введено некорректное значение.");
        }

        public static string Show(int n)
        {
            var str = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                str.Append(i);
                if (i < n)
                {
                    str.Append(", ");
                }
            }

            return str.ToString();
        }
    }
}
