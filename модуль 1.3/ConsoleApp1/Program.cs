using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static void ReduceFraction(int numerator, int denominator)
        {
            int commonDivisor = GCD(numerator, denominator);
            numerator /= commonDivisor;
            denominator /= commonDivisor;
            Console.WriteLine($"Сокращенная дробь: {numerator}/{denominator}");
        }

        static void Main()
        {
            Console.Write("Введите неотрицательный числитель: ");
            int numerator = int.Parse(Console.ReadLine());

            Console.Write("Введите положительный знаменатель: ");
            int denominator = int.Parse(Console.ReadLine());

            if (denominator <= 0)
            {
                Console.WriteLine("Знаменатель должен быть положительным!");
                return;
            }

            ReduceFraction(numerator, denominator);
            Console.ReadLine();
        }
    }
}