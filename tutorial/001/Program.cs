using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            Divide.Test();
            Console.ReadLine();
        }

        delegate double formula(double n);
        delegate double lognat(double n);

        static void InsertAndMergeSort1()
        {
            lognat ln = (double n) => Math.Log2(n);
            formula insert = (double n) => n * n;
            formula merge = (double n) => 64 * n * ln(n);
            int i = 2;

            while (i < 1000000)
            {
                if (merge(i) > insert(i))
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                else
                {
                    break;
                }
                i++;
            }
        }

        static void InsertAndMergeSort2()
        {
            formula insert = (double n) => 100 * (n * n);
            formula merge = (double n) => Math.Pow(2, n);
            int i = 2;

            while (i < 1000)
            {
                Console.Write(i);
                Console.Write(" ");
                if (merge(i) > insert(i))
                {
                    break;
                }

                i++;
            }
        }

        static void Log2(int microseconds)
        {
            formula f1 = (double n) => Math.Log2(n);
            int i = int.MaxValue - 100;

            while (i < int.MaxValue)
            {
                Console.Clear();
                Console.Write($"{i}: {f1(i)}");
                Console.Write(" ");
                if (f1(i) > microseconds)
                {
                    break;
                }

                i++;
            }
        }
        static void Sqrt(int microseconds)
        {
            formula f1 = (double n) => Math.Sqrt(n);
            int i = 1_000_000 - 100;

            while (i < int.MaxValue)
            {
                Console.Clear();
                Console.Write($"{i}: {f1(i)}");
                Console.Write(" ");
                if (f1(i) > microseconds)
                {
                    break;
                }

                i++;
            }
        }
    }
}
