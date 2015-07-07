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
        testlist.AddFirst("dog");
        testlist.AddFirst("fox");
        testlist.AddLast("nuko");


        foreach (string x in testlist)
        {
            Console.WriteLine(x);
        }

        Console.WriteLine("FirstNext => {0}", testlist.First.Next.Value);
        Console.WriteLine("First => {0}", testlist.First.Value);
        Console.WriteLine("Last => {0}", testlist.Last.Value);
       
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

}
