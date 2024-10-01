using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(1, 100);
                Console.Write(array[i] + " ");
            }

            int maxIndex = Array.IndexOf(array, array.Max());

            Console.WriteLine($"\nВведите целое число для замены максимального элемента ({maxIndex + 1} по счёту):");
            int newValue = int.Parse(Console.ReadLine());

            
            array[maxIndex] = newValue;

            Console.WriteLine("Массив после замены максимального элемента:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}