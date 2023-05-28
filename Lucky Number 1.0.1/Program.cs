using System;

namespace Lucky_Number_1._0._1
{
    class Program
    {
        static void Main(string[] args)
        {

            GetAppInfo();

            Greetuser();


            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                int geuss = 0;

                Console.WriteLine("guess the Lucky Number");

                while (geuss != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out geuss))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Enter a number between 1-10");

                        continue;

                    }

                    geuss = Int32.Parse(input);
                    if (geuss != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.DarkRed, "wrong number, please try again");
                      
                    }

                }


                PrintColorMessage(ConsoleColor.DarkYellow, "correct number, you WON!!!");


                Console.WriteLine("Do you want to play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        static void GetAppInfo()
        {
            string AppName = "Lucky Number";
            string AppVersion = "1.0.1";
            string AppAuthor = "Emperor";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}:Version {1} by {2}", AppName, AppVersion, AppAuthor);
            Console.ResetColor();
        }
        static void Greetuser()
        {
            Console.WriteLine("what's your name");
            string name = Console.ReadLine();

            Console.WriteLine("hello {0}, let's play a game....", name);

        }
        static void PrintColorMessage(ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
    
}
