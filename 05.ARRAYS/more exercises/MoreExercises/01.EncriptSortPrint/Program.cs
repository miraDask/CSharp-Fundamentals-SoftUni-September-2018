

namespace _01.EncriptSortPrint
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int limit = int.Parse(Console.ReadLine());

            string result = "";

            for (int i = 0; i < limit; i++)
            {
                char[] letters = Console.ReadLine().ToCharArray();
                int currentSum = 0;

                for (int j = 0; j < letters.Length; j++)
                {

                    if (char.IsUpper(letters[j]))
                    {


                        if (letters[j] == 'A'
                            || letters[j] == 'E'
                            || letters[j] == 'I'
                            || letters[j] == 'O'
                            || letters[j] == 'U')
                        {
                            currentSum += (int)letters[j] * letters.Length;
                        }
                        else
                        {
                            currentSum += (int)letters[j] / letters.Length;
                        }
                    }
                    else
                    {
                        // value += ((int)letters[j] + 32) ;
                        if (letters[j] == 'a'
                            || letters[j] == 'e'
                            || letters[j] == 'i'
                            || letters[j] == 'o'
                            || letters[j] == 'u')
                        {
                            currentSum += (int)letters[j] * letters.Length;
                        }
                        else
                        {
                            currentSum += (int)letters[j] / letters.Length;
                        }
                    }

                }

                result += currentSum + " ";
            }

            int[] sortedResult = result.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < sortedResult.Length; i++)
            {
                for (int j = 0; j < sortedResult.Length - 1; j++)
                {


                    if (sortedResult[j] > sortedResult[j + 1])
                    {
                        int temp = sortedResult[j + 1];
                        sortedResult[j + 1] = sortedResult[j];
                        sortedResult[j] = temp;
                    }
                }

            }
            foreach (var item in sortedResult)
            {
                Console.WriteLine(item);
            }
        }
    }
}

