// Ryan Kelley, Program Template, v0.01
using System; 

namespace MethodsParameters
{
    class MethodsParameters
    {
        // METHOD --  named block of code, can be used over and over.
        // All methods have a SIGNATURE that defines their name, parameters, and output.
        //Example Signature
        static void MyMethod()
        {
            // Console.WriteLine("I like  mine= with lettuce and tomatoes, Heinz 57, and french fried potatoes\n");
        }
        // static -- This methgod belongs to the current class, it is NOT aan object
        // void -- This method has no return value.

        static int DoubleUp();
        {
            int sum = 0;
            Console.WriteLine("This method will double a number and return it.\n");
            Console.WriteLine("Please enter a number on the next line.\n");
            sum = SystemConvert.ToInt32(Console.ReadLine());
            sum *= 2;
            Console.WriteLine(sum);
            return sum;
        }
        
        // Methods with Parameters
        static void MakePancakes(int num)
        {
            Console.WriteLine("You have ordered" + num + "eggs cooked " + style + ".\n" );
        }

        // Using Defaults for Parameters
        static void MakeBurger(int num = 1)
        {
            Console.WriteLine("I am going to cook " + num + "hamburgers.\n");
        } 

        // Named Arguments
        static void AllMyChildren(string child1, string child2, string child3)
        {
            Console.WriteLine("My Favorite child is " + child3);
        }
        // Find Sum of Int
        static int FindSum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Sum: "+ sum);
            return sum;
        }

        // Find Sum of Double
        static double FindSum(int x, int y)
        {
            double sum = x + y;
            Console.WriteLine("Sum: " + sum);
        }

 
        // METHOD OVERLOADING
        static int FindSum(int x, int y)
        {
            int dum = x+ y;
            Console.WriteLine("Sum: " + sum);
            return sum;
        }
        static void Main(string[] args)
        {
            // MyMethod();
            // DoubleUP();
        }
    }
}









