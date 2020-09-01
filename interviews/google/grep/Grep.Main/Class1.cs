using System;

namespace Grep.Main
{
    public class Grep
    {
        public void Entry(string[] array, int context, Predicate<string> pattern)
        {
            int[] indexes = new int[0];
            int[] result = new int[0];

            Find(array, pattern, indexes);

            Build(context, indexes, result);
        }

        private void Find(string[] array, Predicate<string> pattern, int[] indexes)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (pattern(array[i]))
                {
                    int[] temp = new int[indexes.Length];
                    indexes.CopyTo(temp, 0);
                    indexes = new int[indexes.Length + 1];
                    temp.CopyTo(indexes, 0);

                    indexes[indexes.Length] = i;
                }
            }
        }

        private void Build(int context, int[] indexes, int[] result)
        {
            for (int i = 0; i < indexes.Length; i++)
            {
                Range range = new Range(indexes[i] - context, indexes[i] + context);
                Add(range, result);
            }
        }

        private void Add(Range range, int[] result)
        {
            for (int i = range.Start.Value; i < range.End.Value; i++)
            {
                if (NotContains(result, i))
                {
                    result[i] = 
                }
            }
        }

        private bool NotContains(int[] result, int i)
        {
            int k = result[result.Length / 2];

            if (k == i)
            {
                return true;
            }


            int[] param = new int[0];
            if (i > k)
            {
                int lower = result.Length / 2;
                param = new int[lower];
                for (int j = lower; j < result.Length; j++)
                {
                    param[i] = result[i];
                }
            }
            else
            {
                int upper = result.Length / 2;
                param = new int[upper];
                for (int j = 0; j < upper; j++)
                {
                    param[i] = result[i];
                }
            }

            return NotContains(param, i);
        }
    }
}
