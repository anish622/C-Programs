using System;
namespace payment
{
    interface Ipayment
    {
        public void Makepayment(double amount);
    }

    class creditcard : Ipayment
    {
        public void Makepayment(double amount)
        {
            Console.WriteLine(" INR " + amount+ " done through credit card ");
        }
    }

    class paypal : Ipayment
    {
        public void Makepayment(double amount)
        {
            Console.WriteLine(" INR " +  amount  + " done through paypal ");
        }
    }
    class UPI : Ipayment
    {
        public void Makepayment(double amount)
        {
            Console.WriteLine(" INR " +  amount  + " payment through UPI ");
        }
    }

     internal class program
    {
        static void Main()
        {
            creditcard c = new creditcard();
            c.Makepayment(50000.0);
            Console.WriteLine();

            paypal p = new paypal();
            p.Makepayment(6000.0);
                Console.WriteLine();

            UPI i = new UPI();
            i.Makepayment(30000.0);
            Console.WriteLine();

        }
    }
}