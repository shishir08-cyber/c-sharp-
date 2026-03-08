using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

class Display
{
    public void Show(int result)
    {
        Console.WriteLine("Result = " + result);
    }
}

class Program
{
    static void Main()
    {
        Calculator c = new Calculator();
        Display d = new Display();

        int result = c.Add(10, 20);
        d.Show(result);
    }
}