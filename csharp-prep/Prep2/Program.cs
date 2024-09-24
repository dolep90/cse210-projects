using System;

class Program
{
    static void Main()
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        // Core Requirement: Determine the letter grade
        string letter = "";
        string sign = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign (+ or -)
        if (letter == "A")
        {
            // No A+ grade, so only A or A-
            if (percentage % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "F")
        {
            // No F+ or F-, only F
            sign = "";
        }
        else
        {
            // For B, C, D grades, apply + or - based on the last digit
            int lastDigit = percentage % 10;

            if (lastDigit >= 7)
                sign = "+";
            else if (lastDigit < 3)
                sign = "-";
            else
                sign = "";
        }

        // Print out the letter grade with sign
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Determine if the user passed
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Keep trying, you'll get it next time!");
        }
    }
}
