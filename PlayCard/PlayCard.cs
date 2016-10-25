using System;
using System.Collections.Generic;
using System.Linq;


namespace PlayCard
{
    class PlayCard
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var card = new List<string> {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            bool contains = card.Contains(input, StringComparer.Ordinal);
            if (contains == true)
            {
                Console.WriteLine("yes {0}", input);
            }
            else
            {
                Console.WriteLine("no {0}", input);
            }
        }
    }
}
