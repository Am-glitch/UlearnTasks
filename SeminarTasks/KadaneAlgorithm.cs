using System;

namespace SeminarTasks
{
    public class KadaneAlgorithm
    {
        public static int KadaneFindMaxSum(int[] nums)
        {
            var currentSum = nums[0];
            var maxSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currentSum = Math.Max(nums[i], nums[i] + currentSum);
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }

        public static int FindMaximumSum(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int maxSum = int.MinValue;
            int[,] dp = new int[rows + 1, cols + 1];

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    // Добавляем текущий элемент матрицы к сумме предыдущей подматрицы
                    dp[i, j] = matrix[i - 1, j - 1] + dp[i - 1, j] + dp[i, j - 1] - dp[i - 1, j - 1];

                    // Проверяем, является ли текущая сумма максимальной
                    if (dp[i, j] > maxSum)
                    {
                        maxSum = dp[i, j];
                    }
                }
            }
            return maxSum;
        }
    }
}