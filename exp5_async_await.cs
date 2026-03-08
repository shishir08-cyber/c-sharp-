using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Process Started");

        await LongTask();

        Console.WriteLine("Process Finished");
    }

    static async Task LongTask()
    {
        await Task.Delay(3000);
        Console.WriteLine("Task Completed");
    }
}