using System;


namespace Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main(string[] args)
        {
            decimal number1 = decimal.Parse(Console.ReadLine());
            decimal number2 = decimal.Parse(Console.ReadLine());
            decimal number3 = decimal.Parse(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                if (number2 >= number3)
                {
                    Console.WriteLine("{0} {1} {2}", number1, number2, number3);

                }
                else if (number2 <= number3)
                {
                    Console.WriteLine("{0} {1} {2}", number1, number3, number2);
                }
            }
            else if (number2 > number1 && number2 > number3)
            {
                if (number1 >= number3)
                {
                    Console.WriteLine("{0} {1} {2}", number2, number1, number3);

                }
                else if (number1 <= number3)
                {
                    Console.WriteLine("{0} {1} {2}", number2, number3, number1);
                }
            }
            else if (number3 > number1 && number3 > number2)
            {
                if (number1 >= number2)
                {
                    Console.WriteLine("{0} {1} {2}", number3, number1, number2);

                }
                else if (number1 <= number2)
                {
                    Console.WriteLine("{0} {1} {2}", number3, number2, number1);
                }
            }
            else if (number1 == number2 && number1 == number3)
            {
                Console.WriteLine("{0} {1} {2}", number1, number2, number3);
            }
        }
    }
}
