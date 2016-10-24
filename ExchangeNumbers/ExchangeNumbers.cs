using System;

namespace ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double c = new double();

            if (a < b)
            {
                Console.WriteLine(a + " " + b);
            }
            else
            {
                c = a;
                a = b;
                b = c;
                Console.WriteLine(a + " " + b);
            }
        }
    }
}
