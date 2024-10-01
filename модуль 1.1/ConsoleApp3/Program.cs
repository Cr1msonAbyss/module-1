using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string inputString = Console.ReadLine();
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            string revString = new string(charArray);
            Console.WriteLine($"Обратная строка: {revString}");
            Console.Read();
        }
    }
}
