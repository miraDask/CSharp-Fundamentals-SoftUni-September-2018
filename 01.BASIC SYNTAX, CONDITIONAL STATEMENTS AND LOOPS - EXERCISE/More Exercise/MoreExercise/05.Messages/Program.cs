using System;

namespace _05.Messages
{
    public class Program
    {
        public static void Main()
        {
            int limit = int.Parse(Console.ReadLine());
            string letters = "";
            string word = "";

            for (int i = 0; i < limit; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int digit = number % 10;
                string numToDigits = number.ToString();     // that gives me the number of digits /=numToDigits.Length/


                switch (digit)
                {
                    case 2:
                        letters = "abc";
                        break;
                    case 3:
                        letters = "def";
                        break;
                    case 4:
                        letters = "ghi";
                        break;
                    case 5:
                        letters = "jkl";
                        break;
                    case 6:
                        letters = "mno";
                        break;
                    case 7:
                        letters = "pqrs";
                        break;
                    case 8:
                        letters = "tuv";
                        break;
                    case 9:
                        letters = "wxyz";
                        break;
                    case 0:
                        letters = " ";
                        break;

                    default:
                        break;
                }
                word += letters[numToDigits.Length - 1];



            }
            Console.WriteLine(word);
        }
    }
}
