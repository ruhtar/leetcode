namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7 };
            var result = BinarySearch.Find(list, 1);

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
        public static int Find(List<int> list, int target)
        {
            var lastIndex = list.Count - 1;
            int middleIndex = list.Count / 2;

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
