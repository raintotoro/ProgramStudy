using System;
using System.Collections.Generic;
using System.Linq;

class Sort_005_ 
{
    public static void Main(string[] args)
    {
        var numArray = new List<int>();
        Console.WriteLine("終了する場合は｢0｣を入力してください :");
        while (true)
        {
            string s = Console.ReadLine();
            int i = int.Parse(s);
            if (i == 0)
            {
                break;
            }
            numArray.Add(i);
        }
        int[] ary = numArray.ToArray();
        // 昇順
        Array.Sort(ary);
        Console.WriteLine("昇順 :");
        foreach (var n in ary)
        {
            Console.Write(n);
        }
        
        Console.WriteLine("");
        // 降順
        Console.WriteLine("降順 :");
        Array.Reverse(ary);
        foreach (var s in ary)
        {
            Console.Write(s);
        }
        Console.ReadKey();
    }
}

