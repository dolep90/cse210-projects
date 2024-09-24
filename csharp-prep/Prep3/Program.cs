using System;

class Program
{
    static void Main()
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // Generate a random number between 1 and 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);  // 1 to 100

            int guess = 0;
            int guessCount = 0;

            // Loop until the guess matches the magic number
            while (guess != magicNumber)
            {
                // Ask for a guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                // Increment the guess count
                guessCount++;

                // Determine if the guess is higher, lower, or correct
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}