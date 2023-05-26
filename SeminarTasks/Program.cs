using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Способы добраться до кочки
            Console.WriteLine("Количество способов добраться до 3 кочки:");
            Console.WriteLine(FrogJumpsCounter.CountJumpWays(2));
            Console.WriteLine();

            // Fibonacci
            // 1 1 2 3 5 8 13 21 34 55
            Console.WriteLine("Алгоритм фибоначчи:");
            var n = 10;
            Console.WriteLine($"{n} число фибоначчи: " + Fibonacci.FindNthFibonacci(n)); //55
            Console.WriteLine();

            //Прямоугольная область с максимальной суммой
            Console.WriteLine("Квадратная матрица:");
            var matrix = new[,]
            {
                { 0, -1, -5},
                { 10, 12, -2},
                { 6, 8, 0}
            };
            PrintMatrix(matrix);
            Console.WriteLine("Максимальная сумма области в матрице: " + KadaneAlgorithm.FindMaximumSum(matrix));
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
