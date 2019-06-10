namespace _02.Grades
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            PrintsTheCorrespondingGradeInWords(number);
        }

        private static void PrintsTheCorrespondingGradeInWords(double number)
        {
            string correspondingWord = string.Empty;

            if (number >= 2.00 && number <= 2.99)
            {
                correspondingWord = "Fail";
            }
            else if (number >= 3.00 && number <= 3.49)
            {
                correspondingWord = "Poor";
            }
            else if (number >= 3.50 && number <= 4.49)
            {
                correspondingWord = "Good";
            }
            else if (number >= 4.50 && number <= 5.49)
            {
                correspondingWord = "Very good";
            }
            else if (number >= 5.50 && number <= 6.00)
            {
                correspondingWord = "Excellent";
            }

            Console.WriteLine(correspondingWord);
        }
    }
}
