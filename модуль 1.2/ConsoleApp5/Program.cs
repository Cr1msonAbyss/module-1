using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите количество элементов K: ");
            int K = int.Parse(Console.ReadLine());

            char[] alphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            char[] array = new char[K];

            Random random = new Random();

            for (int i = 0; i < K; i++)
            {
                array[i] = alphabet[random.Next(alphabet.Length)];
                Console.Write(array[i] + " ");
            }

            char[] consonants = Array.FindAll(array, c => "бвгджзйклмнпрстфхцчшщ".Contains(c));

            Console.WriteLine("\nСогласные буквы:");
            foreach (var item in consonants)
            {
                Console.Write(item + " ");
            }
            Console.Read();
        }
    }
}
