using System;

class Program
{
    static void Main(string[] args)
    {
        const int ticketPrice = 25;
        bool exitProgram = false;

        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");

        while (!exitProgram)
        {
            Console.WriteLine();
            Console.WriteLine("Please Enter the following number below from the following menu:");
            Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
            Console.WriteLine("2. Exit");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.Write("Enter the number of contestants last year: ");
                    int lastYearContestants;
                    while (!int.TryParse(Console.ReadLine(), out lastYearContestants) || lastYearContestants < 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number of contestants.");
                        Console.Write("Enter the number of contestants last year: ");
                    }

                    Console.Write("Enter the number of contestants this year: ");
                    int thisYearContestants;
                    while (!int.TryParse(Console.ReadLine(), out thisYearContestants) || thisYearContestants < 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number of contestants.");
                        Console.Write("Enter the number of contestants this year: ");
                    }

                    int revenue = thisYearContestants * ticketPrice;
                    bool isBigger = thisYearContestants > lastYearContestants;

                    Console.WriteLine();
                    Console.WriteLine($"Last year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants");
                    Console.WriteLine($"Revenue expected this year is ${revenue}");
                    Console.WriteLine($"It is {isBigger} that this year's competition is bigger than last year's.");
                    break;

                case "2":
                    Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                    exitProgram = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select 1 or 2.");
                    break;
            }
        }
    }
}