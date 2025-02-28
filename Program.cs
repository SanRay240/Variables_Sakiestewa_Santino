using System;

class Program
{
    static void Main()
    {
        // Declares an integer variable named "favoriteNumber"
        int favoriteNumber;
        // Initializes boolean variables "isJumping" and "isRunning" to false on the same line
        bool isJumping = false, isRunning = false;
        // Declares a floating point variable named "myFloat"
        float myFloat;
        // Assigns "favoriteNumber" to your favorite number
        favoriteNumber = 6;
        // Assigns the floating point variable a floating point number
        myFloat = 0.00f;
        // Initializes a constant double that cannot be changed named "finalGrade"
        const double finalGrade = 70.0;

        // Prints out all variables on console
        Console.WriteLine("Favorite Number: " + favoriteNumber);
        Console.WriteLine("Is Jumping: " + isJumping);
        Console.WriteLine("Is Running: " + isRunning);
        Console.WriteLine("Floating Point Value: " + myFloat);
        Console.WriteLine("Final Grade: " + finalGrade);
    }
}