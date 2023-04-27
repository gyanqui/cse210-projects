using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        
        float grade = float.Parse(Console.ReadLine());

        string finalGrade;

        if (grade >= 90)
        {
            finalGrade = "A";
        }
        else if (grade >= 80)
        {
            finalGrade = "B";
        }
        else if (grade >= 70)
        {
            finalGrade = "C";
        }
        else if (grade >= 60)
        {
            finalGrade = "D";
        }
        else
        {
            finalGrade = "F";
        }

        Console.WriteLine("Your final letter grade is: " + finalGrade);

        if (grade >= 70)
        {
            Console.WriteLine("Congrats!! You passed");
        }
        else
        {
            Console.WriteLine("You did not pass, sorry.");
        }
    }
}