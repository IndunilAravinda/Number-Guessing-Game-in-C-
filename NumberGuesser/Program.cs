using System;

class NumberGuess
{
    static void Main(string[] args)
    {
        ///<summary> Choosing nuber range between 0-20 </summary>

        int numberToGuess = new Random().Next(20);

        // Game Instructions
        Console.WriteLine("Welcome to Number Guesser. You need to guess the number that I'm thinking of within the range of 0 & 20");
        Console.WriteLine("----------------------------------------------------------------------------------------------------------");

        // Starting the loop
        bool guessedIncorrect = true;
        int count = 1;
        while (guessedIncorrect)
        {
            Console.WriteLine("");
            Console.WriteLine("Enter your guess, or -1 to give up");

            // recording the guess
            string guess = Console.ReadLine();

            int guessNumber = -1;
            try
            {
                guessNumber = int.Parse(guess);
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");

            }

            // Checking the guess
            if (numberToGuess.Equals(guessNumber))
            {
                Console.WriteLine($"Well Done! You guessed it within {count} attempt");
                guessedIncorrect = false;
            }
            else if (guessNumber.Equals(-1))
            {
                break;
            }
            else if (guessNumber > numberToGuess)
            {

                Console.WriteLine("Lower than " + guessNumber);
                count++;
            }
            else if (guessNumber < numberToGuess)
            {

                Console.WriteLine("Higher than " + guessNumber);
                count++;
            }
            else
            {
                Console.WriteLine("Something is wrong");
                count++;
            }
        }

    }
}