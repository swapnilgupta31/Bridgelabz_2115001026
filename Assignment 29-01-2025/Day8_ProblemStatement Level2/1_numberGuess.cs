using System;
class NumberGuessGame
{
    static void Main(string[] args)
    {
        // Take number input from the user
        Console.WriteLine("Think of a number between 1 to 100, I will guess it!");
        int min = 1, max = 100, guess;
        Random random = new Random();

        // Wait for the user to press Enter to proceed
        Console.WriteLine("Press Enter to proceed...");
        Console.ReadLine(); // User presses Enter

        while (true)
        {
            // Generate a random guess within the current range
            guess = random.Next(min, max + 1);
            Console.WriteLine("Is your number " + guess + "?");
            Console.WriteLine("Click H if the number you think is higher than this , L if the number you think is lower than this , C if that's correct!");

            string input = Console.ReadLine().ToUpper();

            if (input == "C") // For the correct guess
            {
                Console.WriteLine("Hurray! I guessed it! The number was " + guess);
                break; // Exit the loop when the guess is correct
            }
            else if (input == "H") // If the guess is higher than the number
            {
                min = guess + 1; // Lower the maximum range because the number is higher
            }
            else if (input == "L") // If the guess is lower than the number
            {
                max = guess - 1; // Increase the minimum range because the number is lower
            }

            // If the min range exceeds max range, it means there's an inconsistency
            if (min > max)
            {
                Console.WriteLine("Sorry, I couldn't guess the number. There seems to be a mistake!");
                break; // Exit the loop in case of inconsistency
            }
        }
    }
}
