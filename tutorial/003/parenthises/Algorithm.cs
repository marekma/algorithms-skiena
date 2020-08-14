using System;
using System.Collections;
using System.Collections.Generic;

namespace parenthises
{
    public class Algorithm
    {
        public void Test()
        {
            var result = Run("()", out int index);
            Console.WriteLine($"{result} == true {index} == 1");

            result = Run(")", out index);
            Console.WriteLine($"{result} == false {index} == 0");
            
            result = Run("())", out index);
            Console.WriteLine($"{result} == false {index} == 2");
            
            result = Run("((())()(())())", out index);
            Console.WriteLine($"{result} == true {index} == 13");
            
            result = Run("((())", out index);
            Console.WriteLine($"{result} == false {index} == 2");

            result = Run("(()))((())))", out index);
            Console.WriteLine($"{result} == false {index} == 4");
        }

        public bool Run(string source, out int index)
        {
            index = 0;

            var chars = source.ToCharArray();
            var patterns = new char[2] { '(', ')' };

            if (chars[0] == patterns[1])
            {
                return false;
            }
            Stack<char> s = new Stack<char>();
            for (int i = 0; i < chars.Length; i++)
            {
                index = i;
                var c = chars[i];
                if (c == patterns[0])
                {
                    s.Push(c);
                }
                else
                {
                    if (!s.TryPop(out char o))
                    {
                        return false;
                    }
                }
            }

            if (s.Count == 0)
            {
                return index == (chars.Length - 1);
            }

            return false;
        }
    }
}