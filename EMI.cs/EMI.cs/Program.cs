namespace EMI.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a principle loan amount (principle)");
            double principle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter a anual rate interest");
            double anualinterest = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter a  umber of years");
            double year = Convert.ToDouble(Console.ReadLine());
            double monthlyinterest = anualinterest / (12 * 100);
            double v = year * 12;
            double emi = (principle * monthlyinterest * Math.Pow(1 + monthlyinterest , v)) /
                 (Math.Pow(1 + monthlyinterest, v) - 1);
            Console.WriteLine("monthlyemi" + emi);


        }
    }
}
