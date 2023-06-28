using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Blaine";
            string cityState = "Birmingham, Alabama";
            string py = "python";
            string cSharp = "C#";
            string net = ".NET";
            int myAge = 35;
            char gradeA = 'A';
            char gradeB = 'B';
            double myGradeA = 96.5;
            double myGradeB = 84.2;
            decimal courseCostA = 1050;
            decimal courseCostB = 659;
            Console.WriteLine($"My name is {myName}.\n" +
                $"I am {myAge} years old.\n" +
                $"I live in {cityState}.\n" +
                $"Currently I am learning {py} and {net} / {cSharp}.\n" +
                $"For my first two assignments in the Python course, I scored a {myGradeA}{gradeA} and {myGradeB}{gradeB}.\n" +
                $"The Python course cost ${courseCostA} and the C# course cost ${courseCostB}.");
        }
    }
}






