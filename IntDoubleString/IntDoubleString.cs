using System;


namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            byte caseSwith = new byte();
            if (dataType == "integer")
            {
                caseSwith = 1;
            }
            else if (dataType == "real")
            {
                caseSwith = 2;
            }
            else if (dataType == "text")
            {
                caseSwith = 3;
            }
            switch (caseSwith)
            {
                case 1:
                    int inputInt = int.Parse(Console.ReadLine());
                    inputInt = inputInt + 1;
                    Console.WriteLine(inputInt);
                    break;
                case 2:
                    double inputDouble = double.Parse(Console.ReadLine());
                    inputDouble = inputDouble + 1;
                    Console.WriteLine("{0:0.00}", inputDouble);
                    break;
                case 3:
                    string inputStr = Console.ReadLine();
                    inputStr = inputStr;
                    Console.WriteLine("{0}*", inputStr);
                    break;

            }
        }
    }
}
