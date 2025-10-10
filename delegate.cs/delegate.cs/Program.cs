using System;
delegate void Greet();
class program
{
    static void SayHello()
    {
        Console.WriteLine("Hello good morning students!");
    }

    static void Main()
    {
        Greet greetdelegate = SayHello;
        greetdelegate();
    }

}