namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new int[] { 6, 12, 62, 13, 789, 234, 1212, 2, 40, 10, 1000, 200, 333, -4, 0 };
            var sortedList = SelectionSort.Sort(list);
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            };
            Console.ReadLine();
        }
    }

    public class SelectionSort
    {
        public static int[] Sort(int[] list)
        {
            for (int i = 0; i < list.Length - 1; i++)
            {
                var smallest = list[i];
                for (var j = i + 1; j < list.Length; j++)
                {
                    if (list[j] < smallest)
                    {
                        var temp = list[j];
                        list[j] = list[i];
                        list[i] = temp;
                        smallest = temp;
                    }
                }
            }
            return list;
        }
    }
}
