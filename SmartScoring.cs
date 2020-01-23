using System;

namespace CalculatingAverages
{
    class Program
    {
        public static void CalculateGrades(int countOfInputsMax)
        {
            Console.WriteLine("\nThis console application will calculate your average grade given the scores you input!");
            Console.WriteLine("\nTo begin, enter your scores! Make sure the values you enter are between 0 and 100!");
            Console.WriteLine("\nWhen you are ready to calculate your average, enter 000 into the console to calculate your average!");
            double sum = 0;
            
            char letterGrade = 'F';

            //Try, Catch and Finally for exception handling in the for iteration and if statements.
            try
            {
                //This for iteration takes the user input and evaluates for validity (numbers between 0-100)
                for (int i = 1; i <= countOfInputsMax; i++)
                {
                    Console.Write($"\nPlease enter your next value: ");
                    var strsum = Console.ReadLine();
                    double userInput = double.Parse(strsum);

                    //This If statement checks to see if the user entered 000, if they did, it evaluates their inputted values and breaks out of the loop.
                    

                    if (userInput == 000)
                    {
                        i--;
                        double nowAverage = sum / i;
                        if (nowAverage >= 90) letterGrade = 'A';
                        if (nowAverage < 90 && nowAverage >= 80) letterGrade = 'B';
                        if (nowAverage < 80 && nowAverage >= 70) letterGrade = 'C';
                        if (nowAverage < 70 && nowAverage >= 60) letterGrade = 'D';
                        if (nowAverage <= 59) letterGrade = 'F';

                        Console.WriteLine($"\nThe total number of valid scores you entered is {i} and the average of the scores is {nowAverage} which is a {letterGrade}");
                        Console.WriteLine("\nThank you for using this application!");
                        break;
                    }
                    if (userInput > 100.0)
                    {
                        Console.WriteLine("Please enter a valid number between 0-100.");
                        i--;
                        sum = sum - userInput;

                    }
                    if (userInput < 0.0)
                    {
                        Console.WriteLine("Please enter a valid number between 0-100.");
                        i--;
                        userInput = 0;

                    }
                    else
                    {
                        sum = double.Parse(strsum) + sum;

                    }

                }
                double averageOfSum = sum / countOfInputsMax;
            }
            catch
            {
                Console.WriteLine("Your entry was invalid!");

            } finally
            {
                Console.WriteLine("Exiting App!");
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome!");
            CalculateGrades(int.MaxValue);




        }
    }
}