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
            double result = Math.Max(a, Math.Max(b, c));
            Console.WriteLine(result);
        }
    }
}
