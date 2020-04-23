using System;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean runLoop = true;
            Boolean askForContinue = true;

            while (runLoop)
            {
                askForContinue = true;

                string promptMessage = "Please enter a number to run The Power Table Calculator: ";

                int workingInt = ReadInteger(promptMessage);
                int loopingInt = workingInt;

                Console.WriteLine($"{ "Number",-10}{"Squared",-10}{"Cubed",-10}");
                Console.WriteLine($"{"=====",-10}{"=====",-10}{"=====",-10}");

                for (int i = 0; i <= loopingInt; i++)
                {
                    int testingNum = i;
                    Console.WriteLine($"{testingNum,-10}{CalculateSquares(testingNum),-10}{CalculateCubes(testingNum),-10}");
                }

                while(askForContinue)
                {
                    Console.WriteLine("Do you want to run The Power Table Calculator again?");

                    string rerunInput = Console.ReadLine().ToLower();

                        if (rerunInput == "y")
                        {
                            askForContinue = false;
                        }
                        else if (rerunInput == "n")
                        {
                            Console.WriteLine("Thank you for using The Power Table Calculator");
                            askForContinue = false;
                            runLoop = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a y for yes for a n for no.");
                        }
                }

            }
        }

        public static int ReadInteger(string message)
        {
            Console.WriteLine(message);
            int finalInt = 0;
            String input = Console.ReadLine();

            try
            {
                // String input = Console.ReadLine();
                finalInt = int.Parse(input);
                return finalInt;
            }
            catch (Exception)
            {
                Console.WriteLine("Format Error, Please enter a valid whole number.");
                finalInt = ReadInteger(message);
                return finalInt;
            }
        }

        public static int CalculateSquares(int num1)
        {
            int squaredNum = num1 * num1;
            return squaredNum;
        }

        public static int CalculateCubes(int num1)
        {
            int cubedNum = num1 * num1 * num1;
            return cubedNum;
        }

    }
}
