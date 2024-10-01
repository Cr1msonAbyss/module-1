using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, factorial = 1;
            Console.WriteLine("Введите число для расчёта его факториала");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++) 
                {
                factorial = factorial * i;
                }
            Console.WriteLine($"Факториал заданного числа равен {factorial}");
            Console.ReadLine();
        }
    }
}
