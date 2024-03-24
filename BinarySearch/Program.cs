namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            var result = BinarySearch.Find(list, 7);

            if (result == -1)
            {
                Console.WriteLine("The result being search is not on the collection");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("The result is in position number: " + result);
                Console.ReadLine();
            }
        }
    }

    public class BinarySearch
    {
        public static int Find(int[] list, int target)
        {
            var lastIndex = list.Length - 1;
            int middleIndex = list.Length / 2;

            while (true)
            {
                if (list[middleIndex] == target) return middleIndex;

                if ((middleIndex == 0 || middleIndex == lastIndex)) return -1;

                if (list[middleIndex] > target)
                {
                    middleIndex /= 2;
                }
                else
                {
                    middleIndex = (int)Math.Ceiling(((decimal)lastIndex - middleIndex) / 2) + middleIndex;
                }
            }
        }
    }
}
