namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddNodeInTheEnd(5);
            linkedList.AddNodeInTheEnd(1);
            linkedList.AddNodeInTheEnd(1);
            linkedList.AddNodeInTheEnd(9);

            linkedList.AddNodeInTheBeginning(0);

            linkedList.Print();

            linkedList.RemoveNodeFromTheBeginning();

            linkedList.Print();

            linkedList.RemoveNodeFromTheEnd();

            linkedList.Print();

            Console.ReadLine();
        }

        public class LinkedList<T>
        {
            public Node<T> Head { get; set; } = null!;

            public void Print()
            {
                var current = Head;
                if (current == null) {
                    Console.Write("The linked list is empty!");
                }

                while (current != null)
                {
                    Console.Write(current.Value + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }

            public void AddNodeInTheEnd(T value)
            {
                var currentNode = Head;
                if (currentNode == null)
                {
                    Head = new Node<T>(value);
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

            public void AddNodeInTheBeginning(T value)
            {
                var newNode = new Node<T>(value, Head);
                Head = newNode;
            }

            public void RemoveNodeFromTheBeginning()
            {
                if (Head != null)
                    Head = Head.Next;
            }

            public void RemoveNodeFromTheEnd()
            {
                var currentNode = Head;
                if (Head != null)
                {
                    if (Head.Next == null) {
                        Head = null;
                        return;
                    }
                        

                    while (true)
                    {
                        if (currentNode.Next.Next == null)
                        {
                            currentNode.Next = null;
                            break;
                        }
                        currentNode = currentNode.Next;
                    }
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