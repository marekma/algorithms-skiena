using System;

namespace reverse
{
    public class Algorithm
    {
        public void Test()
        {
            Console.WriteLine("Test 1 ----------------");
            LinkedList list = new LinkedList();
            list.Append(new Data("Root"));
            list.Append(new Data("Child-Lev-1"));
            Assert.Equal("Root", list.Head.Data.Name);
            Assert.Equal("Child-Lev-1", list.Tail.Data.Name);

            Console.WriteLine("Test 2 ----------------");
            var result = list.Reverse();
            Assert.Equal("Child-Lev-1", result.Head.Data.Name);
            Assert.Equal("Root", result.Tail.Data.Name);

            Console.WriteLine("Test 3 ----------------");
            list = new LinkedList();
            list.Append(new Data("Root"));
            list.Append(new Data("Child-Lev-1"));
            list.Append(new Data("Child-Lev-2"));
            result = list.Reverse();
            Assert.Equal("Child-Lev-2", result.Head.Data.Name);
            Assert.Equal("Root", result.Tail.Data.Name);
        }
    }

    public class LinkedList
    {
        public LinkedListNode Head { get; private set; }
        public LinkedListNode Tail { get; private set; }

        public void Append(Data data)
        {
            LinkedListNode tail = new LinkedListNode(data);

            if (Head == null)
            {
                Head = tail;
            }
            else
            {
                LinkedListNode prevTail = FindTail();

                prevTail.Next = tail;
            }

            Tail = tail;
        }

        public void Prepend(Data data)
        {
            LinkedListNode head = new LinkedListNode(data);

            if (Head != null)
            {
                head.Next = new LinkedListNode(Head);
            }

            Head = head;

            Tail = FindTail();
        }

        public LinkedList Reverse()
        {
            LinkedListNode next = Head;
            LinkedList reversed = new LinkedList();

            while (next != null)
            {
                reversed.Prepend(next.Data);
                next = next.Next;
            }

            return reversed;
        }

        public LinkedListNode FindTail()
        {
            LinkedListNode tail = Head;

            while (tail != null && tail.Next != null)
            {
                tail = tail.Next;
            }

            return tail;
        }
    }

    public class LinkedListNode
    {
        public Data Data { get; set; }

        public LinkedListNode Next { get; set; }

        public LinkedListNode(Data data)
        {
            Data = data;
        }

        public LinkedListNode(LinkedListNode node)
        {
            Data = node.Data;
            Next = node.Next;
        }
    }

    public class Data
    {
        public Data(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}