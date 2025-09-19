using System;
class program
{
    static void Main()
    {
        try
        {

            Console.WriteLine("enter a first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 / num2;
            Console.WriteLine("Resulr" + result);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Eroor Cannot divide by zero");
        }

        catch(FormatException)
        {
            Console.WriteLine("cannot divivde");
        }
        finally
        {
            Console.WriteLine("division completed");
        }


    }
}
