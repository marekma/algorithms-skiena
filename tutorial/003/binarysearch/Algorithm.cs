using System;
using System.Collections.Generic;
using Algorithms.Asserts;

namespace binarysearch
{
    public class Algorithm
    {
        public void Test()
        {
            OrderedList list = new DescendingOrderedList();
            list.Add("b");
            list.Add("c");
            list.Add("a");
            list.Add("d");
            var result = list.Search("a");
            Assert.Equal("3", result.ToString());

            list = new AscendingOrderedList();
            list.Add("b");
            list.Add("c");
            list.Add("a");
            list.Add("d");
            result = list.Search("a");
            Assert.Equal("0", result.ToString());
        }

        class DescendingOrderedList : OrderedList
        {
            public override void Add(string word)
            {
                int index = list.Count;
                for (int i = list.Count; i > 0; i--)
                {
                    if (list[i - 1].CompareTo(word) > 0)
                    {
                        break;
                    }
                    index--;
                }

                list.Insert(index, word);
            }

            public override int Search(string word)
            {
                return this.Search(this.list, word, list.Count / (int)Math.Pow(2, 1), 1);
            }

            protected override int Search(List<string> list, string word, int i, int step)
            {
                int move = (list.Count / (int)Math.Pow(2, ++step));

                if (word.CompareTo(list[i]) == 0)
                {
                    return i;
                }
                else if (word.CompareTo(list[i]) < 0)
                {
                    i = i + move;
                }
                else
                {
                    i = i - move;
                }

                return this.Search(this.list, word, i, step);
            }
        }

        class AscendingOrderedList : OrderedList
        {
            public override void Add(string word)
            {
                int index = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (word.CompareTo(list[i]) < 0)
                    {
                        break;
                    }
                    index++;
                }

                list.Insert(index, word);
            }

            public override int Search(string word)
            {
                return this.Search(this.list, word, list.Count / (int)Math.Pow(2, 1), 1);
            }

            protected override int Search(List<string> list, string word, int i, int step)
            {
                int move = (list.Count / (int)Math.Pow(2, ++step));
                move = move == 0 ? 1 : move;
                
                if (word.CompareTo(list[i]) == 0)
                {
                    return i;
                }
                else if (word.CompareTo(list[i]) > 0)
                {
                    i = i + move;
                }
                else
                {
                    i = i - move;
                }
                return this.Search(this.list, word, i, step);
            }
        }

        abstract class OrderedList
        {
            protected List<string> list = new List<string>();

            public virtual void Add(string word) { }

            public virtual int Search(string word)
            {
                return this.Search(this.list, word, list.Count / (int)Math.Pow(2, 1), 1);
            }

            protected virtual int Search(List<string> list, string word, int i, int step)
            {
                return -1;
            }
        }
    }
}