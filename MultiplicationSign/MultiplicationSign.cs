using System;


namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            char result;

            if (a < 0)
            {
                if (b < 0)
                {
                    if (c < 0)
                    {
                        result = '-';
                    }
                    else
                    {
                        result = '+';
                    }
                }
                else
                {
                    if (c < 0)
                    {
                        result = '+';
                    }
                    else
                    {
                        result = '-';
                    }
                }
            }
            else
            {
                if (b < 0)
                {
                    if (c < 0)
                    {
                        result = '+';
                    }
                    else
                    {
                        result = '-';
                    }
                }
                else
                {
                    if (c < 0)
                    {
                        result = '-';
                    }
                    else
                    {
                        result = '+';
                    }
                }
            }

            if (a == 0 || b == 0 || c == 0)
            {
                result = '0';
            }

            Console.WriteLine(result);
        }
    }
}
