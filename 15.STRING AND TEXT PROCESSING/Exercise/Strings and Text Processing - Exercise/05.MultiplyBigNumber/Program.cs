namespace _05.MultiplyBigNumber
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string numberSequence = Console.ReadLine();

            int number = int.Parse(Console.ReadLine());

            string resultNumberSequence = string.Empty;

            if (numberSequence == "0" || number == 0)
            {
                Console.WriteLine(0);
                return;
            }


            while (numberSequence[0] == '0')
            {
                numberSequence = numberSequence.Remove(0, 1);
            }

            int residue = 0;

            for (int i = numberSequence.Length - 1; i >= 0; i--)
            {
                int currentNum = int.Parse(numberSequence[i].ToString());
                int tempResult = currentNum * number + residue;
                residue = tempResult / 10;
                int tempNum = tempResult % 10;
                resultNumberSequence += tempNum + "";

            }

            if (residue > 0)
            {
                resultNumberSequence += residue;
            }

            Console.WriteLine(string.Join("", resultNumberSequence.Reverse()));
        }

    }
}
