using System;


namespace BiggestOf3
{
    class BiggestOf3
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine(a);
            }
            if (e > b && e > c && e > d && e > a)
            {
                Console.WriteLine(e);
            }
            if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine(b);
            }
            if (c > b && c > a && c > d && c > e)
            {
                Console.WriteLine(c);
            }
            if (d > b && d > c && d > a && d > e)
            {
 
            }
        }
    }
}