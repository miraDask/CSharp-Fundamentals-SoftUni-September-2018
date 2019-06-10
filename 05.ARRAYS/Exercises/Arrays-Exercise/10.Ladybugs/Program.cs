

namespace _10.Ladybugs
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());

            if (fieldSize == 0)
            {
                return;
            }

            int[] field = new int[fieldSize];

            long[] indexes = Console.ReadLine().Split().Select(long.Parse).ToArray();

            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < indexes.Length; j++)
                {
                    if (i == indexes[j])
                    {
                        field[i] = 1;
                    }
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] comand = input.Split();

                int startIndex = int.Parse(comand[0]);
                int flyLength = int.Parse(comand[2]);
                string direction = comand[1];

                if (startIndex < 0 || startIndex > field.Length - 1)
                {
                    continue;
                }

                if (field[startIndex] == 0)
                {
                    continue;
                }
                else
                {
                    field[startIndex] = 0;
                }

                int finalIndex = startIndex;


                while (true)
                {

                    if (direction == "right")
                    {
                        finalIndex += flyLength;
                    }
                    else
                    {
                        finalIndex -= flyLength;
                    }

                    if (finalIndex < 0 || finalIndex >= field.Length)
                    {
                        break;
                    }

                    if (field[finalIndex] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[finalIndex] = 1;
                        break;
                    }
                }


            }

            Console.WriteLine(string.Join(" ", field));


        }
    }
}
