using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class linearlist_Prog
{
    static void Main(string[] args){
        // 双方向リスト練習
        LinkedList<string> testlist = new LinkedList<string>();

        // リストに(ノード)追加が可
        testlist.AddLast("bear");
        testlist.AddFirst("dog");
        testlist.AddFirst("fox");
        testlist.AddLast("nuko");
        testlist.AddLast("cat");


        foreach (string x in testlist)
        {
            Console.WriteLine(x);
        }

        Console.WriteLine();

        LinkedListNode<string> found;

        // 検索機能(インデックス指定)
        found = testlist.Find("dog");

        Console.WriteLine("[Find]");
        Console.WriteLine("found.Previous: {0}", found.Previous.Value);
        Console.WriteLine("found.Next: {0}", found.Next.Value);
        Console.WriteLine();

        // 検索結果をTrue/Falseで返す
        Console.WriteLine("検索指定(cat) = {0}", testlist.Contains("cat"));
        Console.WriteLine("検索指定(human) = {0}", testlist.Contains("human"));

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

}
