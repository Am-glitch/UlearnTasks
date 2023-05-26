using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarTasks
{
    public class FrogJumpsCounter
    {
        public static int CountJumpWays(int n)
        {
            int[] dp = new int[n + 1];

            // Изначально лягушка находится на первой кочке,
            // поэтому количество способов достичь первой кочки равно 1.
            dp[1] = 1;

            // Вычисляем количество способов достичь остальные кочки в ряду.
            for (int i = 2; i <= n; i++)
            {
                // Лягушка может перепрыгнуть через одну кочку или через две кочки.
                // Поэтому количество способов достичь текущей кочки равно сумме
                // количества способов достичь предыдущей и пред-предыдущей кочек.
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }
    }
}
