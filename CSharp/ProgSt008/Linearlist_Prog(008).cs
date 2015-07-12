using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Linearlist_Prog
{
    static void Main(string[] args)
    {
        var myList = new MyList<string>();

        // リストに(ノード)追加が可
        var list1 = myList.Add("raintotoro").Add("am").Add("I");
        var list2 = myList.Add("I").Add("am").Add("hoge");

        Console.WriteLine(list1);
        // Get(数字)でリストのデータを指定可能
        Console.WriteLine(list1.Get(2));

        list2 = Reverse(list2);
        Console.WriteLine(list2);
        Console.WriteLine();
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    public int[] Reverse(int[] val)
    {
        int len = val.Length;
        int[] result = new int[len];
        for (int i = 0; i < len; i++)
        {
            result[i] = val[len - 1 - i];
        }
        return result;
    }

}

