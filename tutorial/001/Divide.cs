namespace _001
{
    public class Divide
    {
        /// <summary>
        /// Divides a by b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Returns integer results of the division a by b</returns>
        public int Run(int a, int b)
        {
            if (b == 0)
            {
                return -1;
            }
            int i = 0;
            int r = a;
            while (r > 0)
            {
                if (r - b < 0)
                {
                    return i;
                }

                i = i + 1;
                r = r - b;
            }

            return i;
        }

        public static void Test()
        {
            int r = new Divide().Run(5, 2);
            Asserts.Equals(2, r);
            r = new Divide().Run(6, 2);
            Asserts.Equals(3, r);
            r = new Divide().Run(0, 2);
            Asserts.Equals(0, r);
            r = new Divide().Run(2, 0);
            Asserts.Equals(-1, r);
            r = new Divide().Run(5, -2);
            Asserts.Equals(-2, r);
        }
    }
}