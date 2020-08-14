using System;

namespace Algorithms.Excercies
{
    public class Exc01
    {
        public void Test()
        {
            for (int i = 0; i < 20; i++)
            {
                int r = this.Run(i, out int step);
                Console.WriteLine($"n: {i} => R: {r}, S: {step}");
            }
        }

        public int Run(int n, out int step)
        {
            int r = 0;
            step = 0;
            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    for (int k = 1; k <= j; k++)
                    {
                        step++;
                        r = r + 1;
                    }
                }
            }

            return r;
        }
    }
}