namespace RecursiveFibonacci
{
    internal class Program
    {
        //1 1 2 3 5 8 13 21
        static void Main()
        {
            ulong position = 6;
            var result = Fibonacci(position);
            Console.WriteLine($"Position {position}: {result}");

            Console.ReadKey();
        }

        public static ulong Fibonacci(ulong position) => position < 2 ? position : Fibonacci(position - 2) + Fibonacci(position - 1);
    }
}
