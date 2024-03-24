namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>(5);
            stack.Print();

            stack.Push(1);
            stack.Push(2);

            stack.Print();

            stack.Pop();

            stack.Print();

            Console.WriteLine("The element on top of the Stack is: ");
            Console.WriteLine(stack.Peek());

            stack.Pop();

            stack.Print();

            Console.ReadLine();
        }

        public class Stack<T>
        {
            private int MaxSize { get; set; } = 10;
            private int TopIndex { get; set; } = -1; //Which index is on top. -1 means the Stack is empty
            private T[] ArrayData { get; set; }

            public Stack(int size)
            {
                MaxSize = size;
                ArrayData = new T[size];
            }
            public void Print()
            {
                if (IsEmpty())
                    return;

                Console.WriteLine("Items in the Stack are :");

                for (int i = TopIndex; i >= 0; i--)
                    Console.WriteLine(ArrayData[i]);
            }

            public T Peek() {
                if (IsEmpty())
                    return default;

                return ArrayData[TopIndex];
            }

            public void Push(T value)
            {
                if (TopIndex == MaxSize)
                {
                    Console.WriteLine("Stack Overflow");
                    return;
                }

                TopIndex++;
                ArrayData[TopIndex] = value;
            }

            public void Pop()
            {
                if (IsEmpty())
                    return;

                ArrayData[TopIndex] = default;
                TopIndex--;
            }

            private bool IsEmpty() {
                if (TopIndex < 0)
                {
                    Console.WriteLine("Empty stack");
                    return true ;
                }

                return false;
            }
        }
    }
}
