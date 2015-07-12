using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MyList<T>
{
    T val;
    MyList<T> prev;

    MyList(T val, MyList<T> prev)
    {
        this.val = val;
        this.prev = prev;
    }

    public MyList() { }

    public MyList<T> Add(T value)
    {
        return new MyList<T>(value, this);
    }

    public bool IsEmpty()
    {
        return prev == null;
    }

    public int Size()
    {
        if(IsEmpty ()) return 0;
        else return prev.Size() +1;
    }

    public T Get(int index)
    {
        if (index == 0) return val;
        else return prev.Get(index - 1);
    }

    public override string ToString()
    {
        if (IsEmpty()) return ""; 
        else return val.ToString() + " " + prev.ToString();
    }
    
}



