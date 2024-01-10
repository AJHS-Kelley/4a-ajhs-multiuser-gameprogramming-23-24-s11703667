// London Baldwin, Program Template, v0.01
using System;

namespace ReviewProject
{
    class ReviewProject
    {
        static void Main(string[] args)
        {

            // Declaring and Assigning Variables
            // Interger -- -2,147,483,648 to 2,147,483,647
            // Interger = 4 Bytes
            int myInt = 5;

            // Long -- -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            // Long 8 Bytes
            Long myLong = 1928742747242904;

            // Float
            // Float = 4 Bytes
            float myFloat = 3.5F;
            // Double -- Stores up to 15 decimal digits.
            // Double = 8 Bytes
            double myDouble = 9.123456789102345D;
            
            // Boolean -- true / false
            // Boolean = 1 Bit
            bool myBool = false;

            // String
            // 2-Bytes PER CHARACTER 
            // must be in DOUBLE QUOTES " "
            string myString = "i love waffles!";

            // Character (char)
            // Single character, in SINGLE QUOTES ' '
            // 2-Bytes
            char myChar = 'L';

            // Type Casting -- changing one data type to another
            // IMPLICIT -- happens automatically when going smaller -> larger
            // char -> int -> long -> float -> double

             int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myDouble);

            // EXPLICIT -- Must be done manually when goingh larger -> smaller.
            // double -> float -> long -> int -> char
            double exampleDouble = 9.3245678901D;
            int myInt = (int) myDouble;

            // Conversion Methods
            Convert.ToString(myInt)
            Convert.ToDoouble()           
        }
    }
}









