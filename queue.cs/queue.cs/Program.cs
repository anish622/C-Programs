using System;


class Program
{
    public static void Show()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Anish");
        queue.Enqueue("Charlie");
        queue.Enqueue("raam");
        queue.Enqueue("Bob");
        queue.Dequeue();

        foreach (string name in queue)
        {
            Console.WriteLine(name);
        }
    }
}

class MyClass
{
    static void Main()
    {
        Program.Show();
    }

}