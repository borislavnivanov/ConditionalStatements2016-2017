using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            if (score > 0 && score <= 3)
            {
                score = score * 10;
                Console.WriteLine(score);
            }
            else if (score > 3 && score <= 6)
            {
                score = score * 100;
                Console.WriteLine(score);
            }
            else if (score > 6 && score <= 9)
            {
                score = score * 1000;
                Console.WriteLine(score);
            }
            //else if (score == 0)
            //{
            //    Console.WriteLine("0");
            //}
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
