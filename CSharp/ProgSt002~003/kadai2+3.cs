using System;


class Program
{
    static void Main(string[] args)
    {
        sbyte a1 = 0;
        byte a2 = 0;
        short  a3 = 0;
        ushort a4 = 0;
        int a5 = 0;
        uint a6 = 0;
        long a7 = 0;
        ulong a8 = 0;
        char a9 = 'X';
        float a10 = 0;
        double a11 = 0;
        bool a12 = true;
        decimal a13 = 0;
        string a14 = "a";
        
        int i;

        for (i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if(i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
        
        Console.WriteLine("Hello World");


        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

