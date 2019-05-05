using System;

namespace FourGuesses
{
    class MainClass
    {
        public static void Main()
        { 
            int number = new Random().Next(1, 10);
            Console.WriteLine(number);

            for (int guesses = 0; guesses < 4; guesses++)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("Great job! You guessed the number!");
                    return;
                } 
            }
            Console.WriteLine("Oops! You lost!");
        }
    }
}