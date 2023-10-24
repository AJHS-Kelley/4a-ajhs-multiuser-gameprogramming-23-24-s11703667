// Control Flow, london Baldwin, v0.1
using System;

namespace controlFlow
{
    class controlFlow
    {
        static void Main(string[] args)
        {
            // DECLARATIONS
            string favColor = "Pink";
            int luckyNumber = 13;
            float myGPA = 3.0;
            int myAge = 17;
            bool pineappleOnpizza = true;

            // if Statements -- Check for a single condition!
            if (favColor == "Green") {
                Console.WriteLine("Green with envy!");
            }
        }   

            if (myGPA == 4.0) {
                Console.WriteLine("Congrats you have all A's!");
            }

            // if - else Statement -- Checks for a single condition, but has two actions.
            if (myAge > 15) {
                Console.WriteLine("You are eligible to drive");
            } else {
                Console.WriteLine("START WALKING!");
            }

            // if -- else if -- else -- Checks multiple outcomes.
            if (myGPA == 4.0F) {
                Console.WriteLine("Congrats on straight A grades!");
            } else if (myGPA >= 3.0F) {
                Console.WriteLine("Congrats on making the honor roll!");
            } else of (myGpa >= 2.0F){
                Console.WriteLine("You are graduation ready!");
            } else {
                Console.WriteLine("You should probably study!"); 


                // Nested Statements
                if (pineappleOnPizza == true) {
                    Console.WriteLine("Eww, thats gross. You must be a boomer. How old are you?");
                    if (myAge > 60) {
                        Console.WriteLine("Just as i suspected!What was it like having a dinner growing up?");
                } else{
                    Console.WriteLine("Glad to see you have common sense!");
                }
                
            // for loop -- Best for when you know # of interations needed.
            /* 
                for (statement1; staement2; statement3) {
                // Code to loop.
            }
            statement1 is executed ONCE BEFORE the loop starts.
            statement2 is a CONDITIONAL that is checked EVERYTIME BEFORE loop starts.
            statement3 is executed EVERYTIME after the loop executes.
            */

            // for(int i = 0; i < 101; i++) {
            //     Console.WriteLine("" + i);
            // }

            // // Create your own loop that counts down from 100 to 0.
            // for(int i = 100; i > 101; i--) {
            //     Console.WriteLine("" + i);
            // }

            // // Nested Loops
            // for (int i = 1; i <= 2; i++) {
            //     Console.WriteLine("Outer: " + j)

            //     for (int j = 1; j <= 3; j++) {
            //         Console.WriteLine("Inner: " + j);
            //     }
            // }

            // // while loop -- Best used when # of iterations needed is unknown
            // int x = 0 ;
            // while (x < 1000){
            //     Console.WriteLine("" + x);
            //     x++; 
            // }
            
            // // Special Keywords
            // // break will immediately exit a LOOP or an IF /ELSE IF/ELSE block.
            // for (int i = 0; i < 101; i++) {
            //     Console.WriteLine("" + i);
            //     if (i == 50) {
            //         break;
            //     }
            // }

            //continue will SKIP the current iteration
            for (int i = 0; i < 101; i++) {
                Console.WriteLine("" + i);
                if (i == 50) {
                    continue;

    }     
        
}       