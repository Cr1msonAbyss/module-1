using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе целое число: ");
            int num2 = int.Parse(Console.ReadLine());
            int sumResult = num1 + num2;
            Console.WriteLine($"Сумма чисел {num1} и {num2} равна {sumResult}.");
            Console.Read();
        }
    }
}
