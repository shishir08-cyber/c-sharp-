using System;

class Program
{
    delegate int Square(int x);

    static void Main()
    {
        Square s = x => x * x;

        int result = s(5);

        Console.WriteLine("Square = " + result);
    }
}