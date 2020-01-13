using static System.Console;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Declaration
        Queue q = new Queue();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        q.Enqueue(4);

        WriteLine("CONVERT STACK TO QUEUE\n");
        Write("Original Queue: ");
        foreach (int num in q)
            Write(num + " "); // 1 2 3 4      
        WriteLine($"\nOriginal Peek Element: {q.Peek()}");
        WriteLine();

        q.Enqueue(5);
        q.Enqueue(6);
        Write("Ammended Queue: ");
        foreach (int num in q)
            Write(num + " "); // 1 2 3 4 5 6
        WriteLine();
        WriteLine("Ammended Peek element: {0}", q.Peek());

        int ch = (int)q.Dequeue();
        WriteLine("\nRemoved Value: {0}", ch); // 1
        Write("New Queue, Value Removed: ");
        foreach (int num in q)
            Write(num + " ");
        WriteLine();
        WriteLine("Peek element, Value Removed: {0}", q.Peek()); // 2
        Read();
    }
}
