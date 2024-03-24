namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>(10);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Enqueue(4);

            queue.Print();
            queue.Dequeue();
            queue.Dequeue();
            queue.Print();

            Console.ReadLine();
        }

        public class Queue<T>
        {
            private int TopIndex { get; set; } = -1; // -1 means that the queue is empty
            private T[] ArrayData { get; set; }
            private int MaxSize { get; set; }

            private bool IsEmpty() => TopIndex < 0;


            public Queue(int size)
            {
                MaxSize = size;
                ArrayData = new T[MaxSize];
            }

            public void Enqueue(T value)
            {
                if (MaxSize == TopIndex)
                {
                    Console.WriteLine("The queue is full");
                    return;
                }

                TopIndex++;
                ArrayData[TopIndex] = value;
            }

            public void Dequeue()
            {
                if (IsEmpty())
                    return;

                for (int i = 0; i < TopIndex; i++)
                    ArrayData[i] = ArrayData[i + 1];

                ArrayData[TopIndex] = default;

                TopIndex--;
            }

            public void Print()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Empty queue.");
                    return;
                }
                Console.WriteLine("The order of the Queue is: ");

                for (int i = 0; i <= TopIndex; i++)
                {
                    Console.WriteLine(ArrayData[i]);
                }

                Console.WriteLine();
            }

            public void Peek()
            {

            }

        }
    }
}
