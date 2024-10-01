using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static int[,] CreateMatrix(int size)
        {
            Random random = new Random();
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = random.Next(-50, 51); // Генерирует числа от -50 до 50

            return matrix;
        }

        static void SortMatrixByRowSums(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            int[] rowSums = new int[size];

            // Вычисляем суммы строк
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    rowSums[i] += matrix[i, j];

            // Создаем массив индексов
            int[] indices = new int[size];
            for (int i = 0; i < size; i++)
                indices[i] = i;

            // Сортируем индексы по сумме строк
            Array.Sort(rowSums, indices);

            // Создаем новую отсортированную матрицу
            int[,] sortedMatrix = new int[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    sortedMatrix[i, j] = matrix[indices[i], j];

            // Копируем отсортированную матрицу обратно в исходную
            Array.Copy(sortedMatrix, matrix, matrix.Length);
        }

        static void PrintMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }

        static void Main()
        {
            Console.Write("Введите размер квадратной матрицы: ");
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = CreateMatrix(size);

            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix);

            SortMatrixByRowSums(matrix);

            Console.WriteLine("\nМатрица после сортировки по суммам строк:");
            PrintMatrix(matrix);
            Console.Read();
        }
    }
}
