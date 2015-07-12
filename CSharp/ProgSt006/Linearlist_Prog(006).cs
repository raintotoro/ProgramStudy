using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Linearlist_Prog
{
    static void Main(string[] args)
    {
        var myList = new MyList<String>();

        // リストに(ノード)追加が可
        var list1 = myList.Add("raintotoro").Add("am").Add("I");
        Console.WriteLine(list1);
        // Get(数字)でリストのデータを指定可能
        Console.WriteLine(list1.Get(2));

        
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

}

