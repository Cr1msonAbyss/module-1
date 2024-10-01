using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите размер массива N: ");
            int N = int.Parse(Console.ReadLine());
            double[] array = new double[N];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < N; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            double maxElement = array[0];
            for (int i = 1; i < N; i++)
            {
                if (Math.Abs(array[i]) > Math.Abs(maxElement))
                {
                    maxElement = array[i];
                }
            }

            for (int i = 0; i < N; i++)
            {
                array[i] /= maxElement;
            }

            Console.WriteLine("Нормированный массив:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.Read();
        }
    }
}
