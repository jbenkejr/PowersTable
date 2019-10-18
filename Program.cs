using System;

namespace PowersTable
{
    class Program
    {
        static bool goAgain = true;
        static void Main(string[] args)
        {

            GreetingMessage();
            while (goAgain == true)
            {
                Console.Write("Enter an interger: ");
                int userNumber = int.Parse(Console.ReadLine());
                Console.WriteLine();
                PowersOfNumber(userNumber);
                Console.WriteLine();
                Console.Write("Continue? (y/n) ");

                string yesNo = Console.ReadLine();
                if (yesNo.ToLower().Equals("y"))
                {
                    goAgain = true;
                }
                else
                {
                    goAgain = false;
                }
                Console.WriteLine();
            }
        }

        public static void GreetingMessage()
        {
            Console.WriteLine("Learn your squares and cubes!");
            Console.WriteLine();
        }

        public static int Square(int number)
        {
            return number * number;
        }
        public static int Cube(int number)
        {
            return number * number * number;
        }
        public static void PowersOfNumber(int number)
        {
            Console.WriteLine("Number\tSquare\tCube");
            Console.WriteLine("=====\t=====\t=====");

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{i}\t{Square(i)}\t{Cube(i)}");

            }
            if (number == 0 || number <= 0)
            {
                Console.WriteLine("Please choose a valid number");
            }

        }
    }
}
