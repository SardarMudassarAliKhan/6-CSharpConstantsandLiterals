using System;

public class ConstantsAndLiteralsExample
{
    // Constants declaration
    public const int MaxValue = 100;
    public const string ApplicationName = "MyApp";

    public static void Main(string[] args)
    {
        // Integer literal
        int number = 10;

        // Floating-point literal
        double pi = 3.14;

        // Character literal
        char letter = 'A';

        // String literal
        string message = "Hello";

        // Boolean literal
        bool isTrue = true;

        // Displaying the values
        Console.WriteLine("Integer Literal: " + number);
        Console.WriteLine("Floating-Point Literal: " + pi);
        Console.WriteLine("Character Literal: " + letter);
        Console.WriteLine("String Literal: " + message);
        Console.WriteLine("Boolean Literal: " + isTrue);

        // Accessing constants
        Console.WriteLine("Max Value Constant: " + MaxValue);
        Console.WriteLine("Application Name Constant: " + ApplicationName);
    }
}