namespace RecursiveFactorial;

internal class Program
{
    static void Main()
    {
        int number = 5;
        int result = CalculateFactorial(number);

        Console.WriteLine($"Factorial of {number} is {result}");

        Console.ReadKey();
    }
    public static int CalculateFactorial(int num)
    {
        if (num < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(num), "Number must be non-negative.");
        }

        if (num == 0) return 1;

        return num * CalculateFactorial(num - 1);
    }
}
