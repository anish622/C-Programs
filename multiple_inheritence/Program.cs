using System;
interface d1
{
    public void show();
}
interface d2
{
    public void display();
   
}

class Myclass : d1, d2
{
    public void show()
    {
        Console.WriteLine("device used as cameara");
    }
   public void display()
    {
        Console.WriteLine("device used as printer");
    }


}

class program
{
    static void Main()
    {
        Myclass m = new Myclass();
        m.show();
        m.display();

    }
}