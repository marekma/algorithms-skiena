using System;

namespace Algorithms.Excercies
{
    public class Exc46
    {
        public void Test()
        {
            int result = Run(100, 61, 0);
            Console.WriteLine($"7 == {result}");

            result = Run(100, 100, 0);
            Console.WriteLine($"1 == {result}");

            result = Run(100, 1, 0);
            Console.WriteLine($"6 == {result}");
        }
        public int Run(int n, int d, int i)
        {
            int prev = i;
            if (i == 0)
                i++;

            if (d == n)
            {
                return 1;
            }
            else
            {
                double power = Math.Pow(2, i);
                if (prev == 0)
                {
                    i--;
                }
                double div = 1.0 / power;
                double multi = n * div;
                if (n > d)
                {
                    return 1 + Run(n - (int)multi, d, ++i);
                }
                else
                {
                    return 1 + Run(n + (int)multi, d, ++i);
                }
            }
        }
    }
}