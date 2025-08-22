using System;
class Calculator
{
    static void Main()
    {

        Console.WriteLine("enter a first number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter a second number");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter a operators +,-,*,/,%");
        char stmt = Convert.ToChar(Console.ReadLine());
        switch (stmt)
        {
            case '+':
                Console.WriteLine(a + b);
                break;
            case '-':
                Console.WriteLine(a - b);
                break;
            case '*':
                Console.WriteLine(a * b);
                break;
            case '/':
                Console.WriteLine(a / b);
                break;
            case '%':
                Console.WriteLine(a % b);
                break;


        }



    }
}