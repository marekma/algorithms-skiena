using System;

namespace _001
{
    public class Asserts
    {
        public static void Equals(int expected, int result)
        {
            Console.WriteLine($"{result == expected}, expected: {expected}, is: {result}");
        }   
        public static void Equals(string expected, string result)
        {
            Console.WriteLine($"{result == expected}, expected: {expected}, is: {result}");
        }     
    }
}