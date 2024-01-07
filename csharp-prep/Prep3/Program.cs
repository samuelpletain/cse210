using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        int guessesMade = 0;

        int guess = 0;
        do {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
                guessesMade++;
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
                guessesMade++;
            }
            else
            {
                Console.WriteLine("You guessed it!");

                if (guessesMade == 1)
                {
                    Console.WriteLine("It took you 1 guess.");
                }
                else
                {
                    Console.WriteLine($"It took you {guessesMade} guesses.");
                }

                Console.WriteLine("Do you want to play again? (y/n)");
                string playAgain = Console.ReadLine();
                
                if (playAgain == "y")
                {
                    magicNumber = random.Next(1, 101);
                    guessesMade = 0;
                    guess = 0;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                }
            }
        } while (guess != magicNumber);
    }
}