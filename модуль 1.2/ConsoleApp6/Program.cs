using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main()
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(random.NextDouble() * 20 - 10);
                Console.Write(array[i] + " ");
            }

            var sortedIndices = array.Select((value, index) => new { value, index })
                                     .OrderBy(x => x.value)
                                     .Select(x => x.index)
                                     .ToArray();

            Console.WriteLine("\nИндексы в порядке возрастания значений:");
            foreach (var index in sortedIndices)
            {
                Console.Write(index + " ");
            }
            Console.Read();
        }
    }
}
