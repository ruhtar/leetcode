namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddToTheEnd(5);
            linkedList.AddToTheEnd(1);
            linkedList.AddToTheEnd(1);
            linkedList.AddToTheEnd(9);

            linkedList.Print();
            Console.ReadLine();
        }

        public class LinkedList<T>
        {
            public Node<T> Node { get; set; } = null!;

            public void Print()
            {
                var currentNode = Node;
                while (true)
                {
                    Console.WriteLine(currentNode.Value);
                    if (currentNode.Next == null)
                    {
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.Next;
                    }
                }
            }

            public void AddToTheEnd(T value)
            {
                var currentNode = Node;
                if (currentNode == null)
                {
                    Node = new Node<T>(value);
                    return;
                }

                while (true)
                {
                    if (currentNode.Next == null)
                    {
                        var newNode = new Node<T>(value);
                        currentNode.Next = newNode;
                        return;
                    }
                    currentNode = currentNode.Next;
                }
            }
        }

        public class Node<T>
        {
            public T Value { get; set; }
            public Node<T>? Next { get; set; } //Nullable 'cause the last Node has no reference to other nodes.

            public Node(T value, Node<T>? next = null)
            {
                Value = value;
                Next = next;
            }
        }
    }
}