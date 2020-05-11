using System;

namespace numbergame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            System.Console.WriteLine("Would you like to guess a number y/n?");
            string userInput = Console.ReadLine();
            bool playing = userInput.ToLower() == "y";
            Random random = new Random();
            int numberToGuess = random.Next(1,10);
            while(playing)
            {
                System.Console.WriteLine("pick a number between 1 and 10");
                string guess = Console.ReadLine();
                int guessedNumber;
                if(!int.TryParse(guess, out guessedNumber) || guessedNumber > 10 || guessedNumber < 1)
                {
                    System.Console.WriteLine("not a valid number");
                    continue;
                }
                if(guessedNumber == numberToGuess)
                {
                    System.Console.WriteLine("you win! would you like to guess again? y/n");
                    string keepPlaying = Console.ReadLine();
                    if(keepPlaying.ToLower() == "y")
                    {
                        numberToGuess = random.Next(1,10);
                    } 
                    else 
                    {
                        playing = false;
                        continue;
                    }
                }
                else if(numberToGuess > guessedNumber)
                {
                    System.Console.WriteLine("too low");
                }
                else if(numberToGuess < guessedNumber)
                {
                    System.Console.WriteLine("too high");
                }
            }
            }


    }
}
