using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarTasks
{
    public class Fibonacci
    {
        public static long FindNthFibonacci(int n)
        {
            if (n <= 0) throw new ArgumentException();
            if (n <= 2) return 1;

            var fib = new long[n + 1];
            fib[0] = 1;
            fib[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            return fib[n - 1];
        }
    }
}
