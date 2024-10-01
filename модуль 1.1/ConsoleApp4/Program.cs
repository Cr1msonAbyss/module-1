using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[15];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 11);
            }

            Console.WriteLine($"Сгенерированный массив: {string.Join(", ", array)}");

            var positiveNumbers = Array.FindAll(array, num => num > 0);

            if (positiveNumbers.Length > 0)
            {
                double average = positiveNumbers.Average();
                Console.WriteLine($"Среднее значение положительных чисел: {average}");
            }
            else
            {
                Console.WriteLine("В массиве нет положительных чисел.");
            }
            Console.Read();
        }
    }
}
