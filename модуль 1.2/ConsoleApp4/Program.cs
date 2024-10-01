using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите количество элементов K: ");
            int K = int.Parse(Console.ReadLine());

            Random random = new Random();
            int[] array = new int[K];

            for (int i = 0; i < K; i++)
            {
                array[i] = random.Next(1, 100);
                Console.Write(array[i] + " ");
            }

            int minIndex = Array.IndexOf(array, array.Min());
            int maxIndex = Array.IndexOf(array, array.Max());

            if (minIndex > maxIndex)
            {
                (minIndex, maxIndex) = (maxIndex, minIndex);
            }

            Console.WriteLine("\nЭлементы между минимальным и максимальным:");
            for (int i = minIndex + 1; i < maxIndex; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Read();
        }
    }
}
