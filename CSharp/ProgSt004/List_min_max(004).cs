using System;
using System.Collections.Generic;
using System.Linq;

class List_min_max
{
    public static void Main(string[] args)
    {
        var l = new List<int>() { 7, 3, 5, 6, 2, 1, 4 };
        int[] ary = l.ToArray();
        int max = int.MinValue;
        int min = int.MaxValue;
        foreach (var i in ary)
        {
            min = Math.Min(min, i);
            max = Math.Max(max, i);
        }
        Console.WriteLine("最小値は｢{0}｣ 最大値は｢{1}｣です.", min, max);
        Console.ReadKey();
    }
}
