using System;
using System.Collections.Generic;
using System.Linq;

class hoge
{
    static void Main(string[] args)
    {
        Fibonucci f = new Fibonucci();
        // F(0)..F(39)までを列挙する
        // オーバーフローする限界はF(46)
        foreach (var i in f.GetSequence().Take(47))
        {
            Console.WriteLine(i.ToString());
        }
        Console.ReadLine();
    }
}

class Fibonucci
{
    int[] array = new int[] { 0, 1 };
    public IEnumerable<int> GetSequence()
    {
        yield return 0;
        yield return 1;

        while (true)
        {
            int fibo = array[0] + array[1];
            Save(fibo);
            yield return fibo;
        }
    }
    private void Save(int n)
    {
        array[0] = array[1];
        array[1] = n;
    }
}