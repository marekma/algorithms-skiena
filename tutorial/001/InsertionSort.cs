using System;

namespace _001
{
    public class InsertionSort
    {
        private static InsertionSort instance;

        public static InsertionSort Algorithm
        {
            get
            {
                if (instance == null)
                {
                    instance = new InsertionSort();
                }
                return instance;
            }
        }
        public static void Test()
        {
            int[] array = new int[5] { 5, 4, 3, 2, 1 };

            Complexity<int[]> result = new InsertionSort().Run(array);

            Asserts.Equals(1, result.Result[0]);
            Asserts.Equals(5, result.Result[4]);

            Console.WriteLine($"steps: {result.Steps}");
        }

        public Complexity<int[]> Run(int[] array)
        {
            int steps = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int j = i - 1;
                int c = j + 1;
                while (j >= 0 && array[c] < array[j])
                {
                    int k = array[c];
                    array[c] = array[j];
                    array[j] = k;
                    j = j - 1;
                    c = j + 1;
                    steps++;
                }
            }

            return new Complexity<int[]>(array, steps);
        }
    }
}