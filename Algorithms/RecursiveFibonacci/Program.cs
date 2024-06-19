namespace RecursiveFibonacci
{
    internal class Program
    {
        //1 1 2 3 5 8 13 21
        static void Main()
        {
            var position = 6;
            var result = Fibonacci(position);
            Console.WriteLine($"Position {position}: {result}");

            Console.ReadKey();
        }

        public static long Fibonacci(long position)
        {
            if (position <= 0) { return 0; }
            if (position <= 2) { return 1; }
            return Fibonacci(position - 2) + Fibonacci(position - 1);
        }
    }
}
