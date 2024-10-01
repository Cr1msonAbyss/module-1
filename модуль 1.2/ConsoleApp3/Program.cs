using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите количество простых чисел K: ");
            int K = int.Parse(Console.ReadLine());
            int count = 0;
            int number = 2;

            while (count < K)
            {
                if (IsProst(number))
                {
                    Console.Write(number + " ");
                    count++;
                    if (count % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                }
                number++;
            }
            Console.Read();
        }

        static bool IsProst(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}