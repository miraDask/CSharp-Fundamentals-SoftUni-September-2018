using System;

namespace _02.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            int[] previouseRow = new int[limit];

            for (int row = 1; row <= limit; row++)
            {
                int[] currentRow = new int[limit];

                if (row == 1)
                {
                    currentRow[0] = 1;
                    previouseRow = currentRow;
                    Console.WriteLine(1);
                }
                else
                {
                    currentRow[0] = 1;
                    currentRow[currentRow.Length - 1] = 1;


                    for (int i = 1; i < currentRow.Length - 1; i++)
                    {
                                               
                         currentRow[i] = previouseRow[i - 1] + previouseRow[i];
                        
                    }

                    int[] sortedForPrint = new int[row];
                    for (int i = 0; i < sortedForPrint.Length; i++)
                    {
                        sortedForPrint[i] = currentRow[i];
                    }

                    previouseRow = currentRow;

                    Console.WriteLine(string.Join(" ",sortedForPrint));

                }


            }
        }
    }
}
