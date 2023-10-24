// London Baldwin, Program Template, v0.01
/*
Generate secret number from a defined range of numbers (i.e. 0-10, 0-50, 0-100)
Print Game instructions including range and the amount of guesses allowed.
    MATCH == first playuer to score 3 points.
    ROUND == guessing a specific number, until correct or no more attempts.
Ask the Player what number they want to guess.
Determine if guess is correct or not.
    If guess is correct{
        Tell them they guessed correctly.
        Award the player a point.
    } else{
        Tell them they are wrong.
        Tell Player if guess is too high or too
        Check to see if they have guesses remaining{
            if guess remain: {
                allow palyer to gfuess again.
            
            }else {
                CPU wins the round.
            }
        }
    }


*/
using System;

namespace numberGuess
{

    class numberGuess
    {

        static void Main(string[] args)
        {
            int secretNumber = -1;
            int numGuesses = 0; // Number of Guesses player is ALLOWED.
            int numAttempts = 0; // Number of guesses TAKEN.
            int playerScore = 0;
            int playerGuess = 0;
            int cpuScore = 0;
            string difficulty = "";
            int rangeMin = -1;
            int rangeMax = -1;

            Console.WriteLine("Welcome to the Number Guess Game!\nYou will select a difficulty next.\n");
            Console.WriteLine("Easy Mode: Range is 0-10 with 4 guesses.\nNormal Mode: Range is 0-25 with 4 guesses.\nHard Mode: Range is 0-100 with 3 guesses\n");

            // DIFFICULTY SELECTION
            Console.WriteLine(" Please type Easy, Normal, or Hard and press Enter.");
            difficulty = Console.ReadLine();
            // Console.Readline() will save to STRING by default.
            Console.WriteLine("You have selected" + difficulty);
            if (difficulty == "Easy") {
                rangeMin = 0;
                rangeMax = 10;
                numGuesses = 4;

            } else if (NORMAL MODE) {
                // Code to run.
            } else if (HARD MODE) {
                // Code to run.
            } else {
                // Code to run if no difficulty is selected.
        } 
        Console.WriteLine("Minimum: " + rangeMin);
        Console.WriteLine("Maxium: " + rangeMax);
        Console.WriteLine("Num. Guesses: " + numGuesses);

        // Start Match!
        while (playerScore != 3 && cpuScore != 3){
            // Any code ou wnat yo run BEFORE each round goes here.
            // GENERATE SECRET NUMBER
            Random rndNum =new Random();
            secretNumber = rndNum.Next(rangeMin, rangeMax);
            Console.WriteLine("Player Score: " + playerScore + "\n");
            Console.WriteLine("CPU Score:" + cpuScore + "\n");
            // Start Each Round
            for (int i = 0; i < numGuesses ; i++) {
                Console.WriteLine("You have used " + numAttempts + " this round .\n");
                Console.WriteLine("You must guess between" + rangeMin + "and " + rangeMax + \n);
                playerGuess = System.Convert.ToInt32(Console.ReadLine());
                if (playerGuess == secretNumber) {
                    Console.WriteLine("Your guess is too high!\n");   
                } else {
                    

            }
        }    
        

    }
}