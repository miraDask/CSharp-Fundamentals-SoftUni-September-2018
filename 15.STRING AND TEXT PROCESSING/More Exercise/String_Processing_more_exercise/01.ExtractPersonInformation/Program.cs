namespace _01.ExtractPersonInformation
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int limit = int.Parse(Console.ReadLine());

            for (int i = 0; i < limit; i++)
            {
                string input = Console.ReadLine();

                int indexOfSymbolBeforeName = input.IndexOf('@');
                int indexOfSymbolAfterName = input.IndexOf('|');
                int indexOfSymbolBeforeAge = input.IndexOf('#');
                int indexOfSymbolAfterAge = input.IndexOf('*');

                string name = input.Substring(indexOfSymbolBeforeName + 1, indexOfSymbolAfterName - indexOfSymbolBeforeName - 1);
                string age = input.Substring(indexOfSymbolBeforeAge + 1, indexOfSymbolAfterAge - indexOfSymbolBeforeAge - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }

        }
    }
}
