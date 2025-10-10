using System;


class Program
{
    public static void Show()
    {
        Stack<string> stack = new Stack<string>();
        stack.Push("Anish");
        stack.Push("Charlie");
        stack.Push("raam");
        stack.Push("Bob");
        stack.Pop(); 

        foreach (string name in stack)
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









