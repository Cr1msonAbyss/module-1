using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static List<int> CreateArray(int targetSum)
        {
            List<int> array = new List<int>();
            Random random = new Random();
            int currentSum = 0;

            while (currentSum < targetSum)
            {
                int value = random.Next(1, 10);
                if (currentSum + value <= targetSum)
                {
                    array.Add(value);
                    currentSum += value;
                }
            }

            return array;
        }

        static void Main()
        {
            Console.Write("Введите целевую сумму: ");
            int targetSum = int.Parse(Console.ReadLine());

            List<int> resultArray = CreateArray(targetSum);
            Console.WriteLine("Сгенерированный массив: " + string.Join(", ", resultArray));
            Console.Read();
        }
    }
}
