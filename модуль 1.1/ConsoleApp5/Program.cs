using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static bool IsPol(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        static void Main()
        {
            Console.Write("Введите число для проверки на простоту: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsPol(number))
                Console.WriteLine($"Число {number} является простым.");
            else
                Console.WriteLine($"Число {number} не является простым.");
            Console.Read();
        }
    }
}
