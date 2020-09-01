using Algorithms.Asserts;

namespace Heapsort
{
    public class Algorithm
    {
        public void Test()
        {
            int[] array = new int[10] { 5, 4, 1, 56, 3, 12, 7, 99, 11, 10 };
            int[] result = this.Run(array);
            Assert.Equal("1", result[0].ToString());
            Assert.Equal("3", result[1].ToString());
            Assert.Equal("99", result[9].ToString());
        }

        public int[] Run(int[] array)
        {
            int[] heap = this.MakeHeap(array);

            return heap;
        }

        private int[] MakeHeap(int[] array)
        {
            int[] heap = this.Init();
            for (int i = 0; i < array.Length; i++)
            {
                this.Insert(ref heap, array[i]);
            }
            return heap;
        }

        private int[] Init()
        {
            return new int[0];
        }

        private void Insert(ref int[] heap, int x)
        {
            this.Resize(ref heap);
            this.InsertAtEnd(ref heap, x);
            this.BubbleUp(ref heap, heap.Length);
        }

        private void InsertAtEnd(ref int[] arr, int x)
        {
            arr[arr.Length - 1] = x;
        }

        private void Resize(ref int[] heap)
        {
            int[] temp = heap;
            heap = new int[temp.Length + 1];
            temp.CopyTo(heap, 0);
        }

        private void BubbleUp(ref int[] heap, int last)
        {
            int parent = this.Parent(last);
            if (parent == -1)
            {
                return;
            }

            if (heap[parent - 1] > heap[last - 1])
            {
                this.Swap(ref heap, last - 1, parent - 1);
                this.BubbleUp(ref heap, this.Parent(last));
            }
        }

        private void Swap(ref int[] heap, int from, int to)
        {
            int temp = heap[to];
            heap[to] = heap[from];
            heap[from] = temp;
        }

        private int Parent(int n)
        {
            if (n == 1) return -1;
            return (n / 2);
        }

        private int YoungChild(int n)
        {
            return 2 * n;
        }
    }
}