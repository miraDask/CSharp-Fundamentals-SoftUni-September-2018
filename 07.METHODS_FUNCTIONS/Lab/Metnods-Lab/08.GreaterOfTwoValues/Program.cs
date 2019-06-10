namespace _08.GreaterOfTwoValues
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int firstNum = int.Parse(Console.ReadLine());
                    int secondNum = int.Parse(Console.ReadLine());

                    int maxValue = GetMax(firstNum,secondNum);

                        Console.WriteLine(maxValue);
                    
                    break;
                case "char":

                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());

                    char maxValueChar = GetMax(firstChar, secondChar);
                    Console.WriteLine(maxValueChar);

                    break;
                case "string":

                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();

                    string maxValueString = GetMax(firstString, secondString);
                    Console.WriteLine(maxValueString);
                    break;
            }
        }

        private static string GetMax(string firstString, string secondString)
        {

           
            if (firstString.CompareTo(secondString)>= 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }

        

        private static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar >= secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
            
        }

        private static int GetMax(int firstNum, int secondNum)
        {

            if (firstNum >= secondNum)
            {
                return firstNum;
            }
            else 
            {
                return secondNum;
            }
        }
    }
}
