using System;

namespace Algorithms.Asserts
{
    public class Assert
    {
        public static void Equal(string expected, string actual)
        {
            if (expected != actual)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine($"Expected: {expected}, Acutal: {actual}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}