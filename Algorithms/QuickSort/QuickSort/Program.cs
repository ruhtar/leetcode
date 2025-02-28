namespace QuickSort;

internal class Program
{
    static void Main(string[] args)
    {
        var list = new int[] { 6, 12, 62, 13, 789, 234, 1212, 2, 40, 10, 1000, 200, 333, -4, 0 };

        var sortedList = Program.QuickSort(list, 0, list.Length - 1);

        foreach (var item in sortedList)
        {
            Console.WriteLine(item);
        };

        Console.ReadLine();
    }

    public static int[] QuickSort(int[] list, int left, int rigth) 
    {
        var pivot = list[rigth];

        for (int i = left; i < rigth; i++)
        {
            if (list[i] < pivot)
            {
                var temp = list[i];
                list[i] = list[left];
                list[left] = temp;

                left++;
            }
        }

        if (left == rigth) return list;

        list[rigth] = list[left];
        list[left] = pivot;

        QuickSort(list, left + 1, rigth);
        QuickSort(list, 0, left - 1);

        return list;
    }
}
