using System.Security.Cryptography;
using System.Xml.Linq;

namespace BubbleSort;

internal class Program
{
    static void Main(string[] args)
    {
        var list = new int[] { 6, 12, 62, 13, 789, 234, 1212, 2, 40, 10, 1000, 200, 333, -4, 0 };
        var sortedList = Program.BubbleSort(list);
        foreach (var item in sortedList)
        {
            Console.WriteLine(item);
        };
        Console.ReadLine();
    }

    //The name “bubble sort” refers to the way in which larger elements “bubble” to the top or the end of the array, 
    public static int[] BubbleSort(int[] list)
    {
        while (true) 
        {
            var switched = false;

            for (var i = 0; i < list.Length - 1; i++)
            {
                var first = i;
                var second = i + 1;
                if (list[first] > list[second])
                {
                    var temp = list[first];
                    list[first] = list[second];
                    list[second] = temp;
                    switched = true;
                }
            }

            if (!switched) 
            {
                break;
            }
        };

        return list;    
    }
}
