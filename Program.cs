using System;

namespace CalculatingAverages
{
    class Program
    {
        public static void CalculateGrades(int countOfInputsMax)
        {
            Console.WriteLine("\nPlease enter how many scores you would like for me to average!");
            double sum = 0;
            countOfInputsMax = int.Parse(Console.ReadLine());
            char letterGrade = 'F';
            //This for iteration takes the user input and validates it for correctness (0-100) 
            for (int i = 1; i <= countOfInputsMax; i++)
            {
                Console.Write($"\nPlease enter a value for number {i}: ");
                var strsum = Console.ReadLine();
                double userInput = double.Parse(strsum);
                if(userInput > 100.0)
                {
                    Console.WriteLine("Please enter a valid number between 0-100.");
                    i--;                  
                }
                if(userInput < 0.0)
                {
                    Console.WriteLine("Please enter a valid number between 0-100.");
                    i--;                
                }
                else
                {
                    sum = double.Parse(strsum) + sum;
                }

            }
            double averageOfSum = sum / countOfInputsMax;
            if (averageOfSum >=90) letterGrade = 'A';
            if (averageOfSum < 90 && averageOfSum >= 80) letterGrade = 'B';
            if (averageOfSum < 80 && averageOfSum >= 70 ) letterGrade = 'C';
            if (averageOfSum < 70 && averageOfSum >= 60) letterGrade = 'D';
            if (averageOfSum <= 59) letterGrade = 'F';
            Console.WriteLine($"\nThe total number of scores you entered is {countOfInputsMax} and the average of the scores is {averageOfSum} which is a {letterGrade}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Program.CalculateGrades(0);
        }
    }
}
