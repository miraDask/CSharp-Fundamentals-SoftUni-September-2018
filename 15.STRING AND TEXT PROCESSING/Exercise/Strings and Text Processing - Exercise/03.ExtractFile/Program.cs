namespace _03.ExtractFile
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            int firstIndexOfFile = input.LastIndexOf('\\') + 1;
            string file = input.Substring(firstIndexOfFile);
            int firstIndexOfExtantion = file.LastIndexOf('.') + 1;
            string fileName = file.Remove(firstIndexOfExtantion - 1 );
            string fileExtention = file.Substring(firstIndexOfExtantion);

            Console.WriteLine($"File name: {fileName}{Environment.NewLine}File extension: {fileExtention}");
        }
    }
}
