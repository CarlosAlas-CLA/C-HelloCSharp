using System;
using System.IO;

namespace ReadTextFile_WriteToTextFile



{
    class Program
    {
        static void Main(string[] args)
        {
            String files = @"C:\Users\example\Documents\NewT.txt";//Text file path 
            //Variables
            string word = " ";
            string e = "exit";
            //Read all text 
            string excelFile = File.ReadAllText(files);
            Console.WriteLine(excelFile);
            //User input
            Console.WriteLine("Enter text to write to text file");
            //Read all text until user enters exit.
            while (word != e)
            {
                word = Console.ReadLine();
                File.AppendAllText(files, word);
            }
        }
    }
}
